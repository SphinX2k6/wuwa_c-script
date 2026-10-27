using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200168B RID: 5771
	[UnrealObjectPath("/Script/KuroAudioMaterial.KuroAudioMaterialInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroAudioMaterialInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014F22 RID: 85794 RVA: 0x001ECA88 File Offset: 0x001EAC88
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAudioMaterialInfo._ScriptStructPtr != 0) ? FKuroAudioMaterialInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAudioMaterial.KuroAudioMaterialInfo", ref FKuroAudioMaterialInfo._ScriptStructPtr);
		}

		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x06014F23 RID: 85795 RVA: 0x001ECAAC File Offset: 0x001EACAC
		// (set) Token: 0x06014F24 RID: 85796 RVA: 0x001ECAC0 File Offset: 0x001EACC0
		public unsafe TEnumAsByte<EPhysicalSurface> SurfaceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAudioMaterialInfo.__PropertyOffset_SurfaceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAudioMaterialInfo.__PropertyOffset_SurfaceType) = value;
			}
		}

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x06014F25 RID: 85797 RVA: 0x001ECAD5 File Offset: 0x001EACD5
		// (set) Token: 0x06014F26 RID: 85798 RVA: 0x001ECAE9 File Offset: 0x001EACE9
		public unsafe FName FootstepTextureName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAudioMaterialInfo.__PropertyOffset_FootstepTextureName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAudioMaterialInfo.__PropertyOffset_FootstepTextureName) = value;
			}
		}

		// Token: 0x06014F27 RID: 85799 RVA: 0x001ECAFE File Offset: 0x001EACFE
		public FKuroAudioMaterialInfo()
		{
		}

		// Token: 0x06014F28 RID: 85800 RVA: 0x001ECB06 File Offset: 0x001EAD06
		public FKuroAudioMaterialInfo(TEnumAsByte<EPhysicalSurface> SurfaceType, FName FootstepTextureName)
		{
			this.SurfaceType = SurfaceType;
			this.FootstepTextureName = FootstepTextureName;
		}

		// Token: 0x06014F29 RID: 85801 RVA: 0x001ECB1C File Offset: 0x001EAD1C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAudioMaterialInfo.StaticStruct();
		}

		// Token: 0x06014F2A RID: 85802 RVA: 0x001ECB28 File Offset: 0x001EAD28
		[NullableContext(2)]
		public FKuroAudioMaterialInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014F2B RID: 85803 RVA: 0x001ECB32 File Offset: 0x001EAD32
		public FKuroAudioMaterialInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014F2C RID: 85804 RVA: 0x001ECB3D File Offset: 0x001EAD3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAudioMaterialInfo(Pointer, false, true);
		}

		// Token: 0x06014F2D RID: 85805 RVA: 0x001ECB47 File Offset: 0x001EAD47
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAudioMaterialInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B68F RID: 46735
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudioMaterial.KuroAudioMaterialInfo";

		// Token: 0x0400B690 RID: 46736
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B691 RID: 46737
		internal static int __PropertyOffset_SurfaceType;

		// Token: 0x0400B692 RID: 46738
		internal static int __PropertyOffset_FootstepTextureName;
	}
}
