using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DCC RID: 3532
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFrac")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionFrac : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF76 RID: 49014 RVA: 0x00112A15 File Offset: 0x00110C15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFrac._ClassPtr;
		}

		// Token: 0x0600BF77 RID: 49015 RVA: 0x00112A24 File Offset: 0x00110C24
		public UMaterialExpressionFrac() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFrac.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF78 RID: 49016 RVA: 0x00112A4C File Offset: 0x00110C4C
		public UMaterialExpressionFrac(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFrac.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x0600BF79 RID: 49017 RVA: 0x00112A80 File Offset: 0x00110C80
		// (set) Token: 0x0600BF7A RID: 49018 RVA: 0x00112AB9 File Offset: 0x00110CB9
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFrac.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFrac.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x00112ADA File Offset: 0x00110CDA
		static UMaterialExpressionFrac()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFrac");
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x00112AE8 File Offset: 0x00110CE8
		protected UMaterialExpressionFrac(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400655F RID: 25951
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFrac";

		// Token: 0x04006560 RID: 25952
		private static IntPtr _ClassPtr;

		// Token: 0x04006561 RID: 25953
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006562 RID: 25954
		internal static int __PropertyOffset_Input;

		// Token: 0x04006563 RID: 25955
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
