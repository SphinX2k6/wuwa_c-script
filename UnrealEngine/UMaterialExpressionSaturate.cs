using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E31 RID: 3633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSaturate")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionSaturate : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C357 RID: 50007 RVA: 0x0011A09D File Offset: 0x0011829D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSaturate._ClassPtr;
		}

		// Token: 0x0600C358 RID: 50008 RVA: 0x0011A0AC File Offset: 0x001182AC
		public UMaterialExpressionSaturate() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSaturate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C359 RID: 50009 RVA: 0x0011A0D4 File Offset: 0x001182D4
		public UMaterialExpressionSaturate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSaturate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0600C35A RID: 50010 RVA: 0x0011A108 File Offset: 0x00118308
		// (set) Token: 0x0600C35B RID: 50011 RVA: 0x0011A141 File Offset: 0x00118341
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSaturate.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSaturate.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x0011A162 File Offset: 0x00118362
		static UMaterialExpressionSaturate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSaturate");
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x0011A170 File Offset: 0x00118370
		protected UMaterialExpressionSaturate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006824 RID: 26660
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSaturate";

		// Token: 0x04006825 RID: 26661
		private static IntPtr _ClassPtr;

		// Token: 0x04006826 RID: 26662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006827 RID: 26663
		internal static int __PropertyOffset_Input;

		// Token: 0x04006828 RID: 26664
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
