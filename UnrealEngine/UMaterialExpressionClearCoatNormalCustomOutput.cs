using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D9C RID: 3484
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionClearCoatNormalCustomOutput")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionClearCoatNormalCustomOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDD7 RID: 48599 RVA: 0x0010FB98 File Offset: 0x0010DD98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionClearCoatNormalCustomOutput._ClassPtr;
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x0010FBA4 File Offset: 0x0010DDA4
		public UMaterialExpressionClearCoatNormalCustomOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionClearCoatNormalCustomOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x0010FBCC File Offset: 0x0010DDCC
		public UMaterialExpressionClearCoatNormalCustomOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionClearCoatNormalCustomOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x0600BDDA RID: 48602 RVA: 0x0010FC00 File Offset: 0x0010DE00
		// (set) Token: 0x0600BDDB RID: 48603 RVA: 0x0010FC39 File Offset: 0x0010DE39
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionClearCoatNormalCustomOutput.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionClearCoatNormalCustomOutput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x0010FC5A File Offset: 0x0010DE5A
		static UMaterialExpressionClearCoatNormalCustomOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionClearCoatNormalCustomOutput");
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x0010FC68 File Offset: 0x0010DE68
		protected UMaterialExpressionClearCoatNormalCustomOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006445 RID: 25669
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionClearCoatNormalCustomOutput";

		// Token: 0x04006446 RID: 25670
		private static IntPtr _ClassPtr;

		// Token: 0x04006447 RID: 25671
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006448 RID: 25672
		internal static int __PropertyOffset_Input;

		// Token: 0x04006449 RID: 25673
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
