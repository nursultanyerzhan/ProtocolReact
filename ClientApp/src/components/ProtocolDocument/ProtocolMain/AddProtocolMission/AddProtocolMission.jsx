import style from './AddProtocolMission.module.css';
import Modal from 'react-bootstrap/Modal';
import { useForm } from "react-hook-form";
import { useEffect, useState } from 'react';
import { useAddProtocolMissionMutation } from "../../../../services/protocol";
import Select from 'react-select';

export const AddProtocolMission = ({ handleClose, show, mainId }) => {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

  const [addProtocolMission, { isError }] = useAddProtocolMissionMutation();
  const [protocolExecutingDateTypes, setProtocolExecutingDateTypes] = useState([]);
  const [users, setUsers] = useState([]);
  const [selectedUsers, setSelectedUsers] = useState([]);

  useEffect(() => {
    fetch('/getProtocolExecutingDateTypes')
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then(data => {
        setProtocolExecutingDateTypes(data);
      })
      .catch(error => {
        console.error('Error:', error);
      });

    fetch('/getUsers')
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then(data => {
        setUsers(data);
      })
      .catch(error => {
        console.error('Error:', error);
      });
  }, []);

  const onformSubmit = async (data) => {
    const formData = new FormData();

    for (var key in data) {
      if (key === 'Executors')
        continue;
      formData.append(key, data[key]);
      console.log(key);
    }

    formData.append('ProtocolMainId', mainId);
    // formData.append('Executors[]', 12355);

    selectedUsers.forEach(uid => {
      formData.append('Executors[]', uid);
      console.log(uid);
    });

    // console.log(selectedUsers);
    await addProtocolMission(formData);
    handleClose();
  }

  return (
    <Modal show={show} onHide={handleClose} dialogClassName={style["my-modal"]}>
      <Modal.Header closeButton>
        <Modal.Title className={style["modal-title"]}>Добавить поручение</Modal.Title>
      </Modal.Header>
      <form onSubmit={handleSubmit(onformSubmit)}>
        <Modal.Body className={style["modal-body"]}>
          <label className={style["form-label"]}>
            Наименование мероприятий:
            <textarea className={style["form-input"]} {...register("EventName", { required: true })} />
            {errors.EventName && <span className={style["form-error"]}>This field is required</span>}
          </label>
          <br />
          <label className={style["form-label"]}>
            Срок:
            <input type="date" className={style["form-input"]} {...register("Dedline", { required: true })} />
            {errors.Dedline && <span className={style["form-error"]}>This field is required</span>}
          </label>
          <br />
          <label className={style["form-label"]}>
            Периодичность:
            <select className={style["form-select"]} {...register("ProtocolExecutingDateTypeId")}>
              <option value="">Выберите периодичность</option>
              {protocolExecutingDateTypes.map((type) => (
                <option key={type.id} value={type.id}>
                  {type.protocolExecutingDateTypeNameRu}
                </option>
              ))}
            </select>
            {errors.ProtocolExecutingDateTypeId && <span className={style["form-error"]}>This field is required</span>}
          </label>
          <label className={style["form-label"]}>
            Исполнители:
            <Select
              isMulti
              className={style["form-select"]}
              options={users.map((user) => ({
                value: user.uid,
                label: user.fullNameRu,
              }))}
              {...register("Executors")}
              onChange={(selected) => {
                const selectedItems = selected.map((item) => item.value);
                setSelectedUsers(selectedItems);
              }}
            />
          </label>
        </Modal.Body>
        <Modal.Footer className={style["modal-footer"]}>
          <button className="btn btn-primary">Submit</button>
        </Modal.Footer>
      </form>
    </Modal>
  );
};