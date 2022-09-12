export type WorkflowState = {
  title: string;
  orderId: string;
  image: string;
  isDisabled: boolean;
  isCurrentState: boolean;
  messageSentTimeStampUTC: number;
  messageReceivedTimestamp: number;
  messageDeliveredTimestamp: number;
};
