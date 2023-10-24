import cv2

cap = cv2.VideoCapture('rtsp://10.10.30.99:554/media/video1')

while(True):
     ret, frame = cap.read()
     cv2.imshow('frame',frame)
     if cv2.waitKey(1) & 0xFF == ord('q'):
         cv2.destroyAllWindows()
         break

# from ultralytics import YOLO

# Load a model
# model = YOLO("yolov8n.yaml")  # build a new model from scratch
# model = YOLO("yolov8n.pt")  # load a pretrained model (recommended for training)
# results = model(source="./bus.jpg",save=True,save_txt=False,conf=0.4,project='detection_results')
# Use the model
# model.train(data="coco128.yaml", epochs=3)  # train the model
# metrics = model.val()  # evaluate model performance on the validation set
# results = model("https://ultralytics.com/images/bus.jpg")  # predict on an image
# path = model.export(format="onnx")  # export the model to ONNX format