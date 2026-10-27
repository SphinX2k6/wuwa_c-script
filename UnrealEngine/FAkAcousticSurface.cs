using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001E3 RID: 483
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAcousticSurface")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAkAcousticSurface : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001C7D RID: 7293 RVA: 0x0002A824 File Offset: 0x00028A24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkAcousticSurface._ScriptStructPtr != 0) ? FAkAcousticSurface._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkAcousticSurface", ref FAkAcousticSurface._ScriptStructPtr);
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x0002A848 File Offset: 0x00028A48
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x0002A858 File Offset: 0x00028A58
		public unsafe uint Texture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAcousticSurface.__PropertyOffset_Texture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAcousticSurface.__PropertyOffset_Texture) = (int)value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0002A869 File Offset: 0x00028A69
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0002A879 File Offset: 0x00028A79
		public unsafe float Occlusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAcousticSurface.__PropertyOffset_Occlusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAcousticSurface.__PropertyOffset_Occlusion) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0002A88A File Offset: 0x00028A8A
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x0002A89E File Offset: 0x00028A9E
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkAcousticSurface.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkAcousticSurface.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0002A8B3 File Offset: 0x00028AB3
		public FAkAcousticSurface()
		{
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0002A8BB File Offset: 0x00028ABB
		public FAkAcousticSurface(uint Texture, float Occlusion, string Name)
		{
			this.Texture = Texture;
			this.Occlusion = Occlusion;
			this.Name = Name;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0002A8D8 File Offset: 0x00028AD8
		protected override IntPtr GetUStructPtr()
		{
			return FAkAcousticSurface.StaticStruct();
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0002A8E4 File Offset: 0x00028AE4
		[NullableContext(2)]
		public FAkAcousticSurface(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0002A8EE File Offset: 0x00028AEE
		public FAkAcousticSurface(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0002A8F9 File Offset: 0x00028AF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkAcousticSurface(Pointer, false, true);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0002A903 File Offset: 0x00028B03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkAcousticSurface(Pointer, MemoryOwner);
		}

		// Token: 0x04000949 RID: 2377
		public const string __ObjectPath = "/Script/AkAudio.AkAcousticSurface";

		// Token: 0x0400094A RID: 2378
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400094B RID: 2379
		internal static int __PropertyOffset_Texture;

		// Token: 0x0400094C RID: 2380
		internal static int __PropertyOffset_Occlusion;

		// Token: 0x0400094D RID: 2381
		internal static int __PropertyOffset_Name;
	}
}
