using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000249 RID: 585
	[UnrealObjectPath("/Script/AkAudio.AkSurfacePoly")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAkSurfacePoly : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002295 RID: 8853 RVA: 0x000333F3 File Offset: 0x000315F3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkSurfacePoly._ScriptStructPtr != 0) ? FAkSurfacePoly._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkSurfacePoly", ref FAkSurfacePoly._ScriptStructPtr);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x00033417 File Offset: 0x00031617
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x0003342B File Offset: 0x0003162B
		[Nullable(2)]
		public unsafe UAkAcousticTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAcousticTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FAkSurfacePoly.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAkSurfacePoly.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00033440 File Offset: 0x00031640
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00033450 File Offset: 0x00031650
		public unsafe float Occlusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSurfacePoly.__PropertyOffset_Occlusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSurfacePoly.__PropertyOffset_Occlusion) = value;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00033461 File Offset: 0x00031661
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00033471 File Offset: 0x00031671
		public unsafe bool EnableSurface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSurfacePoly.__PropertyOffset_EnableSurface) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSurfacePoly.__PropertyOffset_EnableSurface) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00033482 File Offset: 0x00031682
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00033492 File Offset: 0x00031692
		public unsafe float SurfaceArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSurfacePoly.__PropertyOffset_SurfaceArea);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSurfacePoly.__PropertyOffset_SurfaceArea) = value;
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000334A3 File Offset: 0x000316A3
		public FAkSurfacePoly()
		{
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000334AB File Offset: 0x000316AB
		[NullableContext(1)]
		public FAkSurfacePoly(UAkAcousticTexture Texture, float Occlusion, bool EnableSurface, float SurfaceArea)
		{
			this.Texture = Texture;
			this.Occlusion = Occlusion;
			this.EnableSurface = EnableSurface;
			this.SurfaceArea = SurfaceArea;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000334D0 File Offset: 0x000316D0
		protected override IntPtr GetUStructPtr()
		{
			return FAkSurfacePoly.StaticStruct();
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000334DC File Offset: 0x000316DC
		[NullableContext(2)]
		public FAkSurfacePoly(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000334E6 File Offset: 0x000316E6
		public FAkSurfacePoly(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000334F1 File Offset: 0x000316F1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkSurfacePoly(Pointer, false, true);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000334FB File Offset: 0x000316FB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkSurfacePoly(Pointer, MemoryOwner);
		}

		// Token: 0x04000BEE RID: 3054
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkSurfacePoly";

		// Token: 0x04000BEF RID: 3055
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000BF0 RID: 3056
		internal static int __PropertyOffset_Texture;

		// Token: 0x04000BF1 RID: 3057
		internal static int __PropertyOffset_Occlusion;

		// Token: 0x04000BF2 RID: 3058
		internal static int __PropertyOffset_EnableSurface;

		// Token: 0x04000BF3 RID: 3059
		internal static int __PropertyOffset_SurfaceArea;
	}
}
