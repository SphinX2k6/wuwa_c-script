using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F81 RID: 8065
	[UnrealObjectPath("/Script/Landscape.LandscapeMaterialTextureStreamingInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLandscapeMaterialTextureStreamingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E982 RID: 125314 RVA: 0x002D77FA File Offset: 0x002D59FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeMaterialTextureStreamingInfo._ScriptStructPtr != 0) ? FLandscapeMaterialTextureStreamingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeMaterialTextureStreamingInfo", ref FLandscapeMaterialTextureStreamingInfo._ScriptStructPtr);
		}

		// Token: 0x170079BA RID: 31162
		// (get) Token: 0x0601E983 RID: 125315 RVA: 0x002D781E File Offset: 0x002D5A1E
		// (set) Token: 0x0601E984 RID: 125316 RVA: 0x002D7832 File Offset: 0x002D5A32
		public unsafe FName TextureName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeMaterialTextureStreamingInfo.__PropertyOffset_TextureName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeMaterialTextureStreamingInfo.__PropertyOffset_TextureName) = value;
			}
		}

		// Token: 0x170079BB RID: 31163
		// (get) Token: 0x0601E985 RID: 125317 RVA: 0x002D7847 File Offset: 0x002D5A47
		// (set) Token: 0x0601E986 RID: 125318 RVA: 0x002D7857 File Offset: 0x002D5A57
		public unsafe float TexelFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeMaterialTextureStreamingInfo.__PropertyOffset_TexelFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeMaterialTextureStreamingInfo.__PropertyOffset_TexelFactor) = value;
			}
		}

		// Token: 0x0601E987 RID: 125319 RVA: 0x002D7868 File Offset: 0x002D5A68
		public FLandscapeMaterialTextureStreamingInfo()
		{
		}

		// Token: 0x0601E988 RID: 125320 RVA: 0x002D7870 File Offset: 0x002D5A70
		public FLandscapeMaterialTextureStreamingInfo(FName TextureName, float TexelFactor)
		{
			this.TextureName = TextureName;
			this.TexelFactor = TexelFactor;
		}

		// Token: 0x0601E989 RID: 125321 RVA: 0x002D7886 File Offset: 0x002D5A86
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeMaterialTextureStreamingInfo.StaticStruct();
		}

		// Token: 0x0601E98A RID: 125322 RVA: 0x002D7892 File Offset: 0x002D5A92
		[NullableContext(2)]
		public FLandscapeMaterialTextureStreamingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E98B RID: 125323 RVA: 0x002D789C File Offset: 0x002D5A9C
		public FLandscapeMaterialTextureStreamingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E98C RID: 125324 RVA: 0x002D78A7 File Offset: 0x002D5AA7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeMaterialTextureStreamingInfo(Pointer, false, true);
		}

		// Token: 0x0601E98D RID: 125325 RVA: 0x002D78B1 File Offset: 0x002D5AB1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeMaterialTextureStreamingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010889 RID: 67721
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeMaterialTextureStreamingInfo";

		// Token: 0x0401088A RID: 67722
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401088B RID: 67723
		internal static int __PropertyOffset_TextureName;

		// Token: 0x0401088C RID: 67724
		internal static int __PropertyOffset_TexelFactor;
	}
}
