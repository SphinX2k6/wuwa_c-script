using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200269C RID: 9884
	[UnrealObjectPath("/Script/Renderer.TransvoxelCompressedAssetBrickEntry")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FTransvoxelCompressedAssetBrickEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024B4B RID: 150347 RVA: 0x003656A3 File Offset: 0x003638A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransvoxelCompressedAssetBrickEntry._ScriptStructPtr != 0) ? FTransvoxelCompressedAssetBrickEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.TransvoxelCompressedAssetBrickEntry", ref FTransvoxelCompressedAssetBrickEntry._ScriptStructPtr);
		}

		// Token: 0x17008DA0 RID: 36256
		// (get) Token: 0x06024B4C RID: 150348 RVA: 0x003656C7 File Offset: 0x003638C7
		// (set) Token: 0x06024B4D RID: 150349 RVA: 0x003656D7 File Offset: 0x003638D7
		public unsafe int Packed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickEntry.__PropertyOffset_Packed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransvoxelCompressedAssetBrickEntry.__PropertyOffset_Packed) = value;
			}
		}

		// Token: 0x06024B4E RID: 150350 RVA: 0x003656E8 File Offset: 0x003638E8
		public FTransvoxelCompressedAssetBrickEntry()
		{
		}

		// Token: 0x06024B4F RID: 150351 RVA: 0x003656F0 File Offset: 0x003638F0
		public FTransvoxelCompressedAssetBrickEntry(int Packed)
		{
			this.Packed = Packed;
		}

		// Token: 0x06024B50 RID: 150352 RVA: 0x003656FF File Offset: 0x003638FF
		protected override IntPtr GetUStructPtr()
		{
			return FTransvoxelCompressedAssetBrickEntry.StaticStruct();
		}

		// Token: 0x06024B51 RID: 150353 RVA: 0x0036570B File Offset: 0x0036390B
		[NullableContext(2)]
		public FTransvoxelCompressedAssetBrickEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B52 RID: 150354 RVA: 0x00365715 File Offset: 0x00363915
		public FTransvoxelCompressedAssetBrickEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024B53 RID: 150355 RVA: 0x00365720 File Offset: 0x00363920
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransvoxelCompressedAssetBrickEntry(Pointer, false, true);
		}

		// Token: 0x06024B54 RID: 150356 RVA: 0x0036572A File Offset: 0x0036392A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransvoxelCompressedAssetBrickEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04013BBD RID: 80829
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.TransvoxelCompressedAssetBrickEntry";

		// Token: 0x04013BBE RID: 80830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013BBF RID: 80831
		internal static int __PropertyOffset_Packed;
	}
}
