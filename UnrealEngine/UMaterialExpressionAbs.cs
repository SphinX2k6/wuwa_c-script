using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D7F RID: 3455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAbs")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionAbs : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BCE1 RID: 48353 RVA: 0x0010DED5 File Offset: 0x0010C0D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAbs._ClassPtr;
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x0010DEE4 File Offset: 0x0010C0E4
		public UMaterialExpressionAbs() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAbs.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x0010DF0C File Offset: 0x0010C10C
		public UMaterialExpressionAbs(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAbs.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x0010DF40 File Offset: 0x0010C140
		// (set) Token: 0x0600BCE5 RID: 48357 RVA: 0x0010DF79 File Offset: 0x0010C179
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionAbs.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionAbs.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x0010DF9A File Offset: 0x0010C19A
		static UMaterialExpressionAbs()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAbs");
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x0010DFA8 File Offset: 0x0010C1A8
		protected UMaterialExpressionAbs(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006398 RID: 25496
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAbs";

		// Token: 0x04006399 RID: 25497
		private static IntPtr _ClassPtr;

		// Token: 0x0400639A RID: 25498
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400639B RID: 25499
		internal static int __PropertyOffset_Input;

		// Token: 0x0400639C RID: 25500
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
