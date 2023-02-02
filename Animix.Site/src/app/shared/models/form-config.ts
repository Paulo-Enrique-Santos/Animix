export interface FormConfig {
    inputConfig: Array<InputConfig>;
    submitButton: ButtonConfig;
    buttonSecundary?: string;
}

export interface InputConfig {
    type: string;
    label: string;
    invalidMessage?: string;
}

export interface ButtonConfig {
    label: string;
}