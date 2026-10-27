using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E54 RID: 3668
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSquareRoot")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionSquareRoot : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4B9 RID: 50361 RVA: 0x0011C94E File Offset: 0x0011AB4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSquareRoot._ClassPtr;
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x0011C95C File Offset: 0x0011AB5C
		public UMaterialExpressionSquareRoot() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSquareRoot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x0011C984 File Offset: 0x0011AB84
		public UMaterialExpressionSquareRoot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSquareRoot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600C4BC RID: 50364 RVA: 0x0011C9B8 File Offset: 0x0011ABB8
		// (set) Token: 0x0600C4BD RID: 50365 RVA: 0x0011C9F1 File Offset: 0x0011ABF1
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSquareRoot.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSquareRoot.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x0011CA12 File Offset: 0x0011AC12
		static UMaterialExpressionSquareRoot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSquareRoot");
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x0011CA20 File Offset: 0x0011AC20
		protected UMaterialExpressionSquareRoot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006919 RID: 26905
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSquareRoot";

		// Token: 0x0400691A RID: 26906
		private static IntPtr _ClassPtr;

		// Token: 0x0400691B RID: 26907
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400691C RID: 26908
		internal static int __PropertyOffset_Input;

		// Token: 0x0400691D RID: 26909
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
