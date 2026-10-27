using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D85 RID: 3461
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArccosineFast")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionArccosineFast : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD13 RID: 48403 RVA: 0x0010E485 File Offset: 0x0010C685
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArccosineFast._ClassPtr;
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x0010E494 File Offset: 0x0010C694
		public UMaterialExpressionArccosineFast() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArccosineFast.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x0010E4BC File Offset: 0x0010C6BC
		public UMaterialExpressionArccosineFast(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArccosineFast.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0600BD16 RID: 48406 RVA: 0x0010E4F0 File Offset: 0x0010C6F0
		// (set) Token: 0x0600BD17 RID: 48407 RVA: 0x0010E529 File Offset: 0x0010C729
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArccosineFast.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArccosineFast.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x0010E54A File Offset: 0x0010C74A
		static UMaterialExpressionArccosineFast()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArccosineFast");
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x0010E558 File Offset: 0x0010C758
		protected UMaterialExpressionArccosineFast(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063BA RID: 25530
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArccosineFast";

		// Token: 0x040063BB RID: 25531
		private static IntPtr _ClassPtr;

		// Token: 0x040063BC RID: 25532
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063BD RID: 25533
		internal static int __PropertyOffset_Input;

		// Token: 0x040063BE RID: 25534
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
