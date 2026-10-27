using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BE4 RID: 3044
	[UnrealObjectPath("/Script/Engine.FontCharacter")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FFontCharacter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060095D8 RID: 38360 RVA: 0x000D5A99 File Offset: 0x000D3C99
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFontCharacter._ScriptStructPtr != 0) ? FFontCharacter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FontCharacter", ref FFontCharacter._ScriptStructPtr);
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x000D5ABD File Offset: 0x000D3CBD
		// (set) Token: 0x060095DA RID: 38362 RVA: 0x000D5ACD File Offset: 0x000D3CCD
		public unsafe int StartU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_StartU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_StartU) = value;
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x060095DB RID: 38363 RVA: 0x000D5ADE File Offset: 0x000D3CDE
		// (set) Token: 0x060095DC RID: 38364 RVA: 0x000D5AEE File Offset: 0x000D3CEE
		public unsafe int StartV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_StartV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_StartV) = value;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x060095DD RID: 38365 RVA: 0x000D5AFF File Offset: 0x000D3CFF
		// (set) Token: 0x060095DE RID: 38366 RVA: 0x000D5B0F File Offset: 0x000D3D0F
		public unsafe int USize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_USize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_USize) = value;
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x000D5B20 File Offset: 0x000D3D20
		// (set) Token: 0x060095E0 RID: 38368 RVA: 0x000D5B30 File Offset: 0x000D3D30
		public unsafe int VSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_VSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_VSize) = value;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x000D5B41 File Offset: 0x000D3D41
		// (set) Token: 0x060095E2 RID: 38370 RVA: 0x000D5B51 File Offset: 0x000D3D51
		public unsafe byte TextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_TextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_TextureIndex) = value;
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x000D5B62 File Offset: 0x000D3D62
		// (set) Token: 0x060095E4 RID: 38372 RVA: 0x000D5B72 File Offset: 0x000D3D72
		public unsafe int VerticalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_VerticalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontCharacter.__PropertyOffset_VerticalOffset) = value;
			}
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x000D5B83 File Offset: 0x000D3D83
		public FFontCharacter()
		{
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x000D5B8B File Offset: 0x000D3D8B
		public FFontCharacter(int StartU, int StartV, int USize, int VSize, byte TextureIndex, int VerticalOffset)
		{
			this.StartU = StartU;
			this.StartV = StartV;
			this.USize = USize;
			this.VSize = VSize;
			this.TextureIndex = TextureIndex;
			this.VerticalOffset = VerticalOffset;
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x000D5BC0 File Offset: 0x000D3DC0
		protected override IntPtr GetUStructPtr()
		{
			return FFontCharacter.StaticStruct();
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x000D5BCC File Offset: 0x000D3DCC
		[NullableContext(2)]
		public FFontCharacter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x000D5BD6 File Offset: 0x000D3DD6
		public FFontCharacter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x000D5BE1 File Offset: 0x000D3DE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFontCharacter(Pointer, false, true);
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x000D5BEB File Offset: 0x000D3DEB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFontCharacter(Pointer, MemoryOwner);
		}

		// Token: 0x04005411 RID: 21521
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FontCharacter";

		// Token: 0x04005412 RID: 21522
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005413 RID: 21523
		internal static int __PropertyOffset_StartU;

		// Token: 0x04005414 RID: 21524
		internal static int __PropertyOffset_StartV;

		// Token: 0x04005415 RID: 21525
		internal static int __PropertyOffset_USize;

		// Token: 0x04005416 RID: 21526
		internal static int __PropertyOffset_VSize;

		// Token: 0x04005417 RID: 21527
		internal static int __PropertyOffset_TextureIndex;

		// Token: 0x04005418 RID: 21528
		internal static int __PropertyOffset_VerticalOffset;
	}
}
