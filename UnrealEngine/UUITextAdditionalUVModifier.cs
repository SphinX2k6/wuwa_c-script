using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021CB RID: 8651
	[UnrealObjectPath("/Script/LGUI.UITextAdditionalUVModifier")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UUITextAdditionalUVModifier : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F52 RID: 134994 RVA: 0x0030A323 File Offset: 0x00308523
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextAdditionalUVModifier._ClassPtr;
		}

		// Token: 0x06020F53 RID: 134995 RVA: 0x0030A330 File Offset: 0x00308530
		public UUITextAdditionalUVModifier() : this(BuiltinUtils.AllocNativeUObject(UUITextAdditionalUVModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F54 RID: 134996 RVA: 0x0030A358 File Offset: 0x00308558
		[NullableContext(1)]
		public UUITextAdditionalUVModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextAdditionalUVModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020F55 RID: 134997 RVA: 0x0030A38B File Offset: 0x0030858B
		public void SetAdditionalUV(int AdditionalUVChannel, in FVector2D UV)
		{
			UUITextAdditionalUVModifier.__SetAdditionalUV_Internal(base.NativePtr, AdditionalUVChannel, UV);
		}

		// Token: 0x06020F56 RID: 134998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalUV_Internal(IntPtr @this, int AdditionalUVChannel, in FVector2D UV);

		// Token: 0x06020F57 RID: 134999 RVA: 0x0030A39A File Offset: 0x0030859A
		static UUITextAdditionalUVModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextAdditionalUVModifier");
		}

		// Token: 0x06020F58 RID: 135000 RVA: 0x0030A3A8 File Offset: 0x003085A8
		protected UUITextAdditionalUVModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401196C RID: 72044
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextAdditionalUVModifier";

		// Token: 0x0401196D RID: 72045
		private static IntPtr _ClassPtr;

		// Token: 0x0401196E RID: 72046
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
