using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017AB RID: 6059
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSDistanceAdjacency_jacobiCloth")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroCSDistanceAdjacency_jacobiCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015F14 RID: 89876 RVA: 0x00202DA0 File Offset: 0x00200FA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSDistanceAdjacency_jacobiCloth._ScriptStructPtr != 0) ? FKuroCSDistanceAdjacency_jacobiCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSDistanceAdjacency_jacobiCloth", ref FKuroCSDistanceAdjacency_jacobiCloth._ScriptStructPtr);
		}

		// Token: 0x17005733 RID: 22323
		// (get) Token: 0x06015F15 RID: 89877 RVA: 0x00202DC4 File Offset: 0x00200FC4
		// (set) Token: 0x06015F16 RID: 89878 RVA: 0x00202DD4 File Offset: 0x00200FD4
		public unsafe int Neighbor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_Neighbor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_Neighbor) = value;
			}
		}

		// Token: 0x17005734 RID: 22324
		// (get) Token: 0x06015F17 RID: 89879 RVA: 0x00202DE5 File Offset: 0x00200FE5
		// (set) Token: 0x06015F18 RID: 89880 RVA: 0x00202DF5 File Offset: 0x00200FF5
		public unsafe float RestLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_RestLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_RestLength) = value;
			}
		}

		// Token: 0x17005735 RID: 22325
		// (get) Token: 0x06015F19 RID: 89881 RVA: 0x00202E06 File Offset: 0x00201006
		// (set) Token: 0x06015F1A RID: 89882 RVA: 0x00202E16 File Offset: 0x00201016
		public unsafe float Pad0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_Pad0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_Pad0) = value;
			}
		}

		// Token: 0x17005736 RID: 22326
		// (get) Token: 0x06015F1B RID: 89883 RVA: 0x00202E27 File Offset: 0x00201027
		// (set) Token: 0x06015F1C RID: 89884 RVA: 0x00202E37 File Offset: 0x00201037
		public unsafe float Pad1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_Pad1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSDistanceAdjacency_jacobiCloth.__PropertyOffset_Pad1) = value;
			}
		}

		// Token: 0x06015F1D RID: 89885 RVA: 0x00202E48 File Offset: 0x00201048
		public FKuroCSDistanceAdjacency_jacobiCloth()
		{
		}

		// Token: 0x06015F1E RID: 89886 RVA: 0x00202E50 File Offset: 0x00201050
		public FKuroCSDistanceAdjacency_jacobiCloth(int Neighbor, float RestLength, float Pad0, float Pad1)
		{
			this.Neighbor = Neighbor;
			this.RestLength = RestLength;
			this.Pad0 = Pad0;
			this.Pad1 = Pad1;
		}

		// Token: 0x06015F1F RID: 89887 RVA: 0x00202E75 File Offset: 0x00201075
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSDistanceAdjacency_jacobiCloth.StaticStruct();
		}

		// Token: 0x06015F20 RID: 89888 RVA: 0x00202E81 File Offset: 0x00201081
		[NullableContext(2)]
		public FKuroCSDistanceAdjacency_jacobiCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015F21 RID: 89889 RVA: 0x00202E8B File Offset: 0x0020108B
		public FKuroCSDistanceAdjacency_jacobiCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015F22 RID: 89890 RVA: 0x00202E96 File Offset: 0x00201096
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSDistanceAdjacency_jacobiCloth(Pointer, false, true);
		}

		// Token: 0x06015F23 RID: 89891 RVA: 0x00202EA0 File Offset: 0x002010A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSDistanceAdjacency_jacobiCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400BF4E RID: 48974
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSDistanceAdjacency_jacobiCloth";

		// Token: 0x0400BF4F RID: 48975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BF50 RID: 48976
		internal static int __PropertyOffset_Neighbor;

		// Token: 0x0400BF51 RID: 48977
		internal static int __PropertyOffset_RestLength;

		// Token: 0x0400BF52 RID: 48978
		internal static int __PropertyOffset_Pad0;

		// Token: 0x0400BF53 RID: 48979
		internal static int __PropertyOffset_Pad1;
	}
}
