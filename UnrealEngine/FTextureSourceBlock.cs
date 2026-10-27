using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011E4 RID: 4580
	[UnrealObjectPath("/Script/Engine.TextureSourceBlock")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTextureSourceBlock : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010DE9 RID: 69097 RVA: 0x0018C685 File Offset: 0x0018A885
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureSourceBlock._ScriptStructPtr != 0) ? FTextureSourceBlock._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextureSourceBlock", ref FTextureSourceBlock._ScriptStructPtr);
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x06010DEA RID: 69098 RVA: 0x0018C6A9 File Offset: 0x0018A8A9
		// (set) Token: 0x06010DEB RID: 69099 RVA: 0x0018C6B9 File Offset: 0x0018A8B9
		public unsafe int BlockX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_BlockX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_BlockX) = value;
			}
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x06010DEC RID: 69100 RVA: 0x0018C6CA File Offset: 0x0018A8CA
		// (set) Token: 0x06010DED RID: 69101 RVA: 0x0018C6DA File Offset: 0x0018A8DA
		public unsafe int BlockY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_BlockY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_BlockY) = value;
			}
		}

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x06010DEE RID: 69102 RVA: 0x0018C6EB File Offset: 0x0018A8EB
		// (set) Token: 0x06010DEF RID: 69103 RVA: 0x0018C6FB File Offset: 0x0018A8FB
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x06010DF0 RID: 69104 RVA: 0x0018C70C File Offset: 0x0018A90C
		// (set) Token: 0x06010DF1 RID: 69105 RVA: 0x0018C71C File Offset: 0x0018A91C
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x06010DF2 RID: 69106 RVA: 0x0018C72D File Offset: 0x0018A92D
		// (set) Token: 0x06010DF3 RID: 69107 RVA: 0x0018C73D File Offset: 0x0018A93D
		public unsafe int NumSlices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_NumSlices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_NumSlices) = value;
			}
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x06010DF4 RID: 69108 RVA: 0x0018C74E File Offset: 0x0018A94E
		// (set) Token: 0x06010DF5 RID: 69109 RVA: 0x0018C75E File Offset: 0x0018A95E
		public unsafe int NumMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_NumMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureSourceBlock.__PropertyOffset_NumMips) = value;
			}
		}

		// Token: 0x06010DF6 RID: 69110 RVA: 0x0018C76F File Offset: 0x0018A96F
		public FTextureSourceBlock()
		{
		}

		// Token: 0x06010DF7 RID: 69111 RVA: 0x0018C777 File Offset: 0x0018A977
		public FTextureSourceBlock(int BlockX, int BlockY, int SizeX, int SizeY, int NumSlices, int NumMips)
		{
			this.BlockX = BlockX;
			this.BlockY = BlockY;
			this.SizeX = SizeX;
			this.SizeY = SizeY;
			this.NumSlices = NumSlices;
			this.NumMips = NumMips;
		}

		// Token: 0x06010DF8 RID: 69112 RVA: 0x0018C7AC File Offset: 0x0018A9AC
		protected override IntPtr GetUStructPtr()
		{
			return FTextureSourceBlock.StaticStruct();
		}

		// Token: 0x06010DF9 RID: 69113 RVA: 0x0018C7B8 File Offset: 0x0018A9B8
		[NullableContext(2)]
		public FTextureSourceBlock(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010DFA RID: 69114 RVA: 0x0018C7C2 File Offset: 0x0018A9C2
		public FTextureSourceBlock(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010DFB RID: 69115 RVA: 0x0018C7CD File Offset: 0x0018A9CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureSourceBlock(Pointer, false, true);
		}

		// Token: 0x06010DFC RID: 69116 RVA: 0x0018C7D7 File Offset: 0x0018A9D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureSourceBlock(Pointer, MemoryOwner);
		}

		// Token: 0x040090B0 RID: 37040
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TextureSourceBlock";

		// Token: 0x040090B1 RID: 37041
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040090B2 RID: 37042
		internal static int __PropertyOffset_BlockX;

		// Token: 0x040090B3 RID: 37043
		internal static int __PropertyOffset_BlockY;

		// Token: 0x040090B4 RID: 37044
		internal static int __PropertyOffset_SizeX;

		// Token: 0x040090B5 RID: 37045
		internal static int __PropertyOffset_SizeY;

		// Token: 0x040090B6 RID: 37046
		internal static int __PropertyOffset_NumSlices;

		// Token: 0x040090B7 RID: 37047
		internal static int __PropertyOffset_NumMips;
	}
}
