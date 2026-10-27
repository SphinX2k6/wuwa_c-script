using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E40 RID: 3648
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSign")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionSign : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3E4 RID: 50148 RVA: 0x0011B015 File Offset: 0x00119215
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSign._ClassPtr;
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x0011B024 File Offset: 0x00119224
		public UMaterialExpressionSign() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSign.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3E6 RID: 50150 RVA: 0x0011B04C File Offset: 0x0011924C
		public UMaterialExpressionSign(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSign.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600C3E7 RID: 50151 RVA: 0x0011B080 File Offset: 0x00119280
		// (set) Token: 0x0600C3E8 RID: 50152 RVA: 0x0011B0B9 File Offset: 0x001192B9
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSign.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSign.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C3E9 RID: 50153 RVA: 0x0011B0DA File Offset: 0x001192DA
		static UMaterialExpressionSign()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSign");
		}

		// Token: 0x0600C3EA RID: 50154 RVA: 0x0011B0E8 File Offset: 0x001192E8
		protected UMaterialExpressionSign(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006882 RID: 26754
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSign";

		// Token: 0x04006883 RID: 26755
		private static IntPtr _ClassPtr;

		// Token: 0x04006884 RID: 26756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006885 RID: 26757
		internal static int __PropertyOffset_Input;

		// Token: 0x04006886 RID: 26758
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
