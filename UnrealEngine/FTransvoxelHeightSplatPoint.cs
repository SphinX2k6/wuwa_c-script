using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026A4 RID: 9892
	[UnrealObjectPath("/Script/Renderer.TransvoxelHeightSplatPoint")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTransvoxelHeightSplatPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024CA7 RID: 150695 RVA: 0x0036708F File Offset: 0x0036528F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelHeightSplatPoint._ScriptStructPtr != 0) ? FTransvoxelHeightSplatPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelHeightSplatPoint", ref FTransvoxelHeightSplatPoint._ScriptStructPtr);
		}

		// Token: 0x17008E28 RID: 36392
		// (get) Token: 0x06024CA8 RID: 150696 RVA: 0x003670B3 File Offset: 0x003652B3
		// (set) Token: 0x06024CA9 RID: 150697 RVA: 0x003670C3 File Offset: 0x003652C3
		public unsafe float HeightAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightSplatPoint.__PropertyOffset_HeightAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightSplatPoint.__PropertyOffset_HeightAlpha) = value;
			}
		}

		// Token: 0x17008E29 RID: 36393
		// (get) Token: 0x06024CAA RID: 150698 RVA: 0x003670D4 File Offset: 0x003652D4
		// (set) Token: 0x06024CAB RID: 150699 RVA: 0x003670E4 File Offset: 0x003652E4
		public unsafe int TextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelHeightSplatPoint.__PropertyOffset_TextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelHeightSplatPoint.__PropertyOffset_TextureIndex) = value;
			}
		}

		// Token: 0x06024CAC RID: 150700 RVA: 0x003670F5 File Offset: 0x003652F5
		public FTransvoxelHeightSplatPoint()
		{
		}

		// Token: 0x06024CAD RID: 150701 RVA: 0x003670FD File Offset: 0x003652FD
		public FTransvoxelHeightSplatPoint(float HeightAlpha, int TextureIndex)
		{
			this.HeightAlpha = HeightAlpha;
			this.TextureIndex = TextureIndex;
		}

		// Token: 0x06024CAE RID: 150702 RVA: 0x00367113 File Offset: 0x00365313
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelHeightSplatPoint.StaticStruct();
		}

		// Token: 0x06024CAF RID: 150703 RVA: 0x0036711F File Offset: 0x0036531F
		[NullableContext(2)]
		public FTransvoxelHeightSplatPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024CB0 RID: 150704 RVA: 0x00367129 File Offset: 0x00365329
		public FTransvoxelHeightSplatPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024CB1 RID: 150705 RVA: 0x00367134 File Offset: 0x00365334
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelHeightSplatPoint(Pointer, false, true);
		}

		// Token: 0x06024CB2 RID: 150706 RVA: 0x0036713E File Offset: 0x0036533E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelHeightSplatPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04013C67 RID: 80999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.TransvoxelHeightSplatPoint";

		// Token: 0x04013C68 RID: 81000
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013C69 RID: 81001
		internal static int __PropertyOffset_HeightAlpha;

		// Token: 0x04013C6A RID: 81002
		internal static int __PropertyOffset_TextureIndex;
	}
}
