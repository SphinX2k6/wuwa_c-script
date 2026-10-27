using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E6E RID: 3694
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTransformPosition")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionTransformPosition : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C597 RID: 50583 RVA: 0x0011E1E3 File Offset: 0x0011C3E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTransformPosition._ClassPtr;
		}

		// Token: 0x0600C598 RID: 50584 RVA: 0x0011E1F0 File Offset: 0x0011C3F0
		public UMaterialExpressionTransformPosition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTransformPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x0011E218 File Offset: 0x0011C418
		[NullableContext(1)]
		public UMaterialExpressionTransformPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTransformPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600C59A RID: 50586 RVA: 0x0011E24C File Offset: 0x0011C44C
		// (set) Token: 0x0600C59B RID: 50587 RVA: 0x0011E285 File Offset: 0x0011C485
		[Nullable(1)]
		public FExpressionInput Input
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTransformPosition.__PropertyOffset_Input, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTransformPosition.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0600C59C RID: 50588 RVA: 0x0011E2A6 File Offset: 0x0011C4A6
		// (set) Token: 0x0600C59D RID: 50589 RVA: 0x0011E2BA File Offset: 0x0011C4BA
		public unsafe TEnumAsByte<EMaterialPositionTransformSource> TransformSourceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTransformPosition.__PropertyOffset_TransformSourceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTransformPosition.__PropertyOffset_TransformSourceType) = value;
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0600C59E RID: 50590 RVA: 0x0011E2CF File Offset: 0x0011C4CF
		// (set) Token: 0x0600C59F RID: 50591 RVA: 0x0011E2E3 File Offset: 0x0011C4E3
		public unsafe TEnumAsByte<EMaterialPositionTransformSource> TransformType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTransformPosition.__PropertyOffset_TransformType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTransformPosition.__PropertyOffset_TransformType) = value;
			}
		}

		// Token: 0x0600C5A0 RID: 50592 RVA: 0x0011E2F8 File Offset: 0x0011C4F8
		static UMaterialExpressionTransformPosition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTransformPosition");
		}

		// Token: 0x0600C5A1 RID: 50593 RVA: 0x0011E306 File Offset: 0x0011C506
		protected UMaterialExpressionTransformPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069B3 RID: 27059
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTransformPosition";

		// Token: 0x040069B4 RID: 27060
		private static IntPtr _ClassPtr;

		// Token: 0x040069B5 RID: 27061
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069B6 RID: 27062
		internal static int __PropertyOffset_Input;

		// Token: 0x040069B7 RID: 27063
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x040069B8 RID: 27064
		internal static int __PropertyOffset_TransformSourceType;

		// Token: 0x040069B9 RID: 27065
		internal static int __PropertyOffset_TransformType;
	}
}
