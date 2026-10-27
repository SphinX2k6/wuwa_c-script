using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BDF RID: 7135
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentWorldSubsystem")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKuroVirtualAttachmentWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B64A RID: 112202 RVA: 0x00285D70 File Offset: 0x00283F70
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVirtualAttachmentWorldSubsystem._ClassPtr;
		}

		// Token: 0x0601B64B RID: 112203 RVA: 0x00285D7C File Offset: 0x00283F7C
		public UKuroVirtualAttachmentWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualAttachmentWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B64C RID: 112204 RVA: 0x00285DA4 File Offset: 0x00283FA4
		[NullableContext(1)]
		public UKuroVirtualAttachmentWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualAttachmentWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B64D RID: 112205 RVA: 0x00285DD7 File Offset: 0x00283FD7
		[NullableContext(2)]
		public UKuroVirtualAttachmentParentComponent GetRegisteredParentComponent(in FGuid Uid)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroVirtualAttachmentParentComponent>(UKuroVirtualAttachmentWorldSubsystem.__GetRegisteredParentComponent_Internal(base.NativePtr, Uid));
		}

		// Token: 0x0601B64E RID: 112206 RVA: 0x00285DEA File Offset: 0x00283FEA
		[NullableContext(1)]
		public TArray<UKuroVirtualAttachmentChildComponent> GetRegisteredChildComponents(in FGuid Uid)
		{
			return new TArray<UKuroVirtualAttachmentChildComponent>(UKuroVirtualAttachmentWorldSubsystem.__GetRegisteredChildComponents_Internal(base.NativePtr, Uid), null);
		}

		// Token: 0x0601B64F RID: 112207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredParentComponent_Internal(IntPtr @this, in FGuid Uid);

		// Token: 0x0601B650 RID: 112208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredChildComponents_Internal(IntPtr @this, in FGuid Uid);

		// Token: 0x0601B651 RID: 112209 RVA: 0x00285DFE File Offset: 0x00283FFE
		static UKuroVirtualAttachmentWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentWorldSubsystem");
		}

		// Token: 0x0601B652 RID: 112210 RVA: 0x00285E0C File Offset: 0x0028400C
		protected UKuroVirtualAttachmentWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBF0 RID: 60400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentWorldSubsystem";

		// Token: 0x0400EBF1 RID: 60401
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBF2 RID: 60402
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
