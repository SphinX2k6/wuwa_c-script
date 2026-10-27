using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026A6 RID: 9894
	[UnrealObjectPath("/Script/Renderer.TransvoxelRenderHeightSplatPoint")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTransvoxelRenderHeightSplatPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024CDE RID: 150750 RVA: 0x00367533 File Offset: 0x00365733
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelRenderHeightSplatPoint._ScriptStructPtr != 0) ? FTransvoxelRenderHeightSplatPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelRenderHeightSplatPoint", ref FTransvoxelRenderHeightSplatPoint._ScriptStructPtr);
		}

		// Token: 0x17008E3D RID: 36413
		// (get) Token: 0x06024CDF RID: 150751 RVA: 0x00367557 File Offset: 0x00365757
		// (set) Token: 0x06024CE0 RID: 150752 RVA: 0x00367567 File Offset: 0x00365767
		public unsafe float HeightAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelRenderHeightSplatPoint.__PropertyOffset_HeightAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelRenderHeightSplatPoint.__PropertyOffset_HeightAlpha) = value;
			}
		}

		// Token: 0x17008E3E RID: 36414
		// (get) Token: 0x06024CE1 RID: 150753 RVA: 0x00367578 File Offset: 0x00365778
		// (set) Token: 0x06024CE2 RID: 150754 RVA: 0x00367588 File Offset: 0x00365788
		public unsafe int TextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelRenderHeightSplatPoint.__PropertyOffset_TextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelRenderHeightSplatPoint.__PropertyOffset_TextureIndex) = value;
			}
		}

		// Token: 0x06024CE3 RID: 150755 RVA: 0x00367599 File Offset: 0x00365799
		public FTransvoxelRenderHeightSplatPoint()
		{
		}

		// Token: 0x06024CE4 RID: 150756 RVA: 0x003675A1 File Offset: 0x003657A1
		public FTransvoxelRenderHeightSplatPoint(float HeightAlpha, int TextureIndex)
		{
			this.HeightAlpha = HeightAlpha;
			this.TextureIndex = TextureIndex;
		}

		// Token: 0x06024CE5 RID: 150757 RVA: 0x003675B7 File Offset: 0x003657B7
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelRenderHeightSplatPoint.StaticStruct();
		}

		// Token: 0x06024CE6 RID: 150758 RVA: 0x003675C3 File Offset: 0x003657C3
		[NullableContext(2)]
		public FTransvoxelRenderHeightSplatPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024CE7 RID: 150759 RVA: 0x003675CD File Offset: 0x003657CD
		public FTransvoxelRenderHeightSplatPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024CE8 RID: 150760 RVA: 0x003675D8 File Offset: 0x003657D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelRenderHeightSplatPoint(Pointer, false, true);
		}

		// Token: 0x06024CE9 RID: 150761 RVA: 0x003675E2 File Offset: 0x003657E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelRenderHeightSplatPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04013C86 RID: 81030
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.TransvoxelRenderHeightSplatPoint";

		// Token: 0x04013C87 RID: 81031
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013C88 RID: 81032
		internal static int __PropertyOffset_HeightAlpha;

		// Token: 0x04013C89 RID: 81033
		internal static int __PropertyOffset_TextureIndex;
	}
}
