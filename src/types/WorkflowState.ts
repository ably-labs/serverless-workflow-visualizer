export type WorkflowState = {
  title: string;
  orderId: string;
  image: string;
  isDisabled: boolean;
  isCurrentState: boolean;
  messageSentTimeStampUTC: string;
  messageReceivedTimestamp: string;
  messageDeliveredTimestamp: string;
};
