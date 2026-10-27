using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002684 RID: 9860
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Renderer.ChunkCoord")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FChunkCoord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060249DC RID: 149980 RVA: 0x0036363B File Offset: 0x0036183B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChunkCoord._ScriptStructPtr != 0) ? FChunkCoord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.ChunkCoord", ref FChunkCoord._ScriptStructPtr);
		}

		// Token: 0x17008D30 RID: 36144
		// (get) Token: 0x060249DD RID: 149981 RVA: 0x0036365F File Offset: 0x0036185F
		// (set) Token: 0x060249DE RID: 149982 RVA: 0x0036366F File Offset: 0x0036186F
		public unsafe int ChunkX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkCoord.__PropertyOffset_ChunkX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkCoord.__PropertyOffset_ChunkX) = value;
			}
		}

		// Token: 0x17008D31 RID: 36145
		// (get) Token: 0x060249DF RID: 149983 RVA: 0x00363680 File Offset: 0x00361880
		// (set) Token: 0x060249E0 RID: 149984 RVA: 0x00363690 File Offset: 0x00361890
		public unsafe int ChunkY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkCoord.__PropertyOffset_ChunkY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkCoord.__PropertyOffset_ChunkY) = value;
			}
		}

		// Token: 0x17008D32 RID: 36146
		// (get) Token: 0x060249E1 RID: 149985 RVA: 0x003636A1 File Offset: 0x003618A1
		// (set) Token: 0x060249E2 RID: 149986 RVA: 0x003636B1 File Offset: 0x003618B1
		public unsafe int ChunkZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkCoord.__PropertyOffset_ChunkZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkCoord.__PropertyOffset_ChunkZ) = value;
			}
		}

		// Token: 0x060249E3 RID: 149987 RVA: 0x003636C2 File Offset: 0x003618C2
		public FChunkCoord()
		{
		}

		// Token: 0x060249E4 RID: 149988 RVA: 0x003636CA File Offset: 0x003618CA
		public FChunkCoord(int ChunkX, int ChunkY, int ChunkZ)
		{
			this.ChunkX = ChunkX;
			this.ChunkY = ChunkY;
			this.ChunkZ = ChunkZ;
		}

		// Token: 0x060249E5 RID: 149989 RVA: 0x003636E7 File Offset: 0x003618E7
		protected override IntPtr GetUStructPtr()
		{
			return FChunkCoord.StaticStruct();
		}

		// Token: 0x060249E6 RID: 149990 RVA: 0x003636F3 File Offset: 0x003618F3
		[NullableContext(2)]
		public FChunkCoord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060249E7 RID: 149991 RVA: 0x003636FD File Offset: 0x003618FD
		public FChunkCoord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060249E8 RID: 149992 RVA: 0x00363708 File Offset: 0x00361908
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChunkCoord(Pointer, false, true);
		}

		// Token: 0x060249E9 RID: 149993 RVA: 0x00363712 File Offset: 0x00361912
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChunkCoord(Pointer, MemoryOwner);
		}

		// Token: 0x04013AE6 RID: 80614
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.ChunkCoord";

		// Token: 0x04013AE7 RID: 80615
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013AE8 RID: 80616
		internal static int __PropertyOffset_ChunkX;

		// Token: 0x04013AE9 RID: 80617
		internal static int __PropertyOffset_ChunkY;

		// Token: 0x04013AEA RID: 80618
		internal static int __PropertyOffset_ChunkZ;
	}
}
