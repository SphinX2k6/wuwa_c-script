using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200251D RID: 9501
	[UnrealObjectPath("/Script/Niagara.MeshTriCoordinate")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMeshTriCoordinate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060234CD RID: 144589 RVA: 0x00343592 File Offset: 0x00341792
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshTriCoordinate._ScriptStructPtr != 0) ? FMeshTriCoordinate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.MeshTriCoordinate", ref FMeshTriCoordinate._ScriptStructPtr);
		}

		// Token: 0x170087C9 RID: 34761
		// (get) Token: 0x060234CE RID: 144590 RVA: 0x003435B6 File Offset: 0x003417B6
		// (set) Token: 0x060234CF RID: 144591 RVA: 0x003435C6 File Offset: 0x003417C6
		public unsafe int Tri
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshTriCoordinate.__PropertyOffset_Tri);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshTriCoordinate.__PropertyOffset_Tri) = value;
			}
		}

		// Token: 0x170087CA RID: 34762
		// (get) Token: 0x060234D0 RID: 144592 RVA: 0x003435D7 File Offset: 0x003417D7
		// (set) Token: 0x060234D1 RID: 144593 RVA: 0x003435EB File Offset: 0x003417EB
		public unsafe FVector BaryCoord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshTriCoordinate.__PropertyOffset_BaryCoord);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshTriCoordinate.__PropertyOffset_BaryCoord) = value;
			}
		}

		// Token: 0x060234D2 RID: 144594 RVA: 0x00343600 File Offset: 0x00341800
		public FMeshTriCoordinate()
		{
		}

		// Token: 0x060234D3 RID: 144595 RVA: 0x00343608 File Offset: 0x00341808
		public FMeshTriCoordinate(int Tri, FVector BaryCoord)
		{
			this.Tri = Tri;
			this.BaryCoord = BaryCoord;
		}

		// Token: 0x060234D4 RID: 144596 RVA: 0x0034361E File Offset: 0x0034181E
		protected override IntPtr GetUStructPtr()
		{
			return FMeshTriCoordinate.StaticStruct();
		}

		// Token: 0x060234D5 RID: 144597 RVA: 0x0034362A File Offset: 0x0034182A
		[NullableContext(2)]
		public FMeshTriCoordinate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060234D6 RID: 144598 RVA: 0x00343634 File Offset: 0x00341834
		public FMeshTriCoordinate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060234D7 RID: 144599 RVA: 0x0034363F File Offset: 0x0034183F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshTriCoordinate(Pointer, false, true);
		}

		// Token: 0x060234D8 RID: 144600 RVA: 0x00343649 File Offset: 0x00341849
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshTriCoordinate(Pointer, MemoryOwner);
		}

		// Token: 0x04012F35 RID: 77621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.MeshTriCoordinate";

		// Token: 0x04012F36 RID: 77622
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F37 RID: 77623
		internal static int __PropertyOffset_Tri;

		// Token: 0x04012F38 RID: 77624
		internal static int __PropertyOffset_BaryCoord;
	}
}
