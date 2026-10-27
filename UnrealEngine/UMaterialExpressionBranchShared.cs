using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D94 RID: 3476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBranchShared")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionBranchShared : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD8F RID: 48527 RVA: 0x0010F369 File Offset: 0x0010D569
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBranchShared._ClassPtr;
		}

		// Token: 0x0600BD90 RID: 48528 RVA: 0x0010F378 File Offset: 0x0010D578
		public UMaterialExpressionBranchShared() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBranchShared.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD91 RID: 48529 RVA: 0x0010F3A0 File Offset: 0x0010D5A0
		public UMaterialExpressionBranchShared(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBranchShared.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0600BD92 RID: 48530 RVA: 0x0010F3D4 File Offset: 0x0010D5D4
		// (set) Token: 0x0600BD93 RID: 48531 RVA: 0x0010F40D File Offset: 0x0010D60D
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBranchShared.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBranchShared.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x0010F42E File Offset: 0x0010D62E
		static UMaterialExpressionBranchShared()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBranchShared");
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x0010F43C File Offset: 0x0010D63C
		protected UMaterialExpressionBranchShared(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006414 RID: 25620
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBranchShared";

		// Token: 0x04006415 RID: 25621
		private static IntPtr _ClassPtr;

		// Token: 0x04006416 RID: 25622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006417 RID: 25623
		internal static int __PropertyOffset_Input;

		// Token: 0x04006418 RID: 25624
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
