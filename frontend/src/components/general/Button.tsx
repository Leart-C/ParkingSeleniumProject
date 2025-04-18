interface IProps {
  variant: "primary" | "secondary" | "danger" | "light";
  type: "submit" | "button";
  label: string;
  onClick: () => void;
  loading?: boolean;
  disabled?: boolean;
}

const Button = ({
  variant,
  type,
  label,
  onClick,
  loading,
  disabled,
}: IProps) => {
  const baseClass =
    "flex justify-center items-center outline-none duration-300 h-10 text-lg font-semibold px-6 rounded-2xl border-2 disabled:shadow-none disabled:bg-gray-300 disabled:border-gray-300";

  const variants: Record<string, string> = {
    primary:
      "text-white bg-[rgb(117,78,180)] border-[rgb(117,78,180)] hover:shadow-[0_0_5px_5px_rgba(117,78,180,0.3)]",
    secondary:
      "text-white bg-amber-400 border-amber-400 hover:shadow-[0_0_5px_5px_#fbbe2465]",
    danger:
      "text-white bg-[rgb(174,137,154)] border-[rgb(174,137,154)] hover:shadow-[0_0_5px_5px_rgba(174,137,154,0.44)]",
    light:
      "text-[rgb(117,78,180)] border-[rgb(117,78,180)] hover:shadow-[0_0_5px_5px_rgba(117,78,180,0.3)]",
  };

  const className = `${baseClass} ${variants[variant]}`;

  const loadingIcon = () => (
    <div className="w-6 h-6 rounded-full animate-spin border-2 border-gray-400 border-t-gray-800"></div>
  );

  return (
    <button
      type={type}
      onClick={onClick}
      className={className}
      disabled={disabled}
      data-testid={`btn-${variant}`}
    >
      {loading ? loadingIcon() : label}
    </button>
  );
};

export default Button;
