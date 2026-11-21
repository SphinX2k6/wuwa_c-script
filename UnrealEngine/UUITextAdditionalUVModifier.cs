using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072F RID: 1839
	[UnrealObjectPath("/Script/LGUI.UITextAdditionalUVModifier")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UUITextAdditionalUVModifier : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A04F RID: 41039 RVA: 0x000ED5F3 File Offset: 0x000EB7F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextAdditionalUVModifier._ClassPtr;
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x000ED600 File Offset: 0x000EB800
		public UUITextAdditionalUVModifier() : this(BuiltinUtils.AllocNativeUObject(UUITextAdditionalUVModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x000ED628 File Offset: 0x000EB828
		[NullableContext(1)]
		public UUITextAdditionalUVModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextAdditionalUVModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x000ED65B File Offset: 0x000EB85B
		public void SetAdditionalUV(int AdditionalUVChannel, in FVector2D UV)
		{
			UUITextAdditionalUVModifier.__SetAdditionalUV_Internal(base.NativePtr, AdditionalUVChannel, UV);
		}

		// Token: 0x0600A053 RID: 41043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalUV_Internal(IntPtr @this, int AdditionalUVChannel, in FVector2D UV);

		// Token: 0x0600A054 RID: 41044 RVA: 0x000ED66A File Offset: 0x000EB86A
		static UUITextAdditionalUVModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextAdditionalUVModifier");
		}

		// Token: 0x0600A055 RID: 41045 RVA: 0x000ED678 File Offset: 0x000EB878
		protected UUITextAdditionalUVModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044A3 RID: 17571
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextAdditionalUVModifier";

		// Token: 0x040044A4 RID: 17572
		private static IntPtr _ClassPtr;

		// Token: 0x040044A5 RID: 17573
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
