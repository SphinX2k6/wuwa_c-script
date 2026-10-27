using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200199D RID: 6557
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.IEMeshQueryResult")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FIEMeshQueryResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060185E3 RID: 99811 RVA: 0x0023ED78 File Offset: 0x0023CF78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIEMeshQueryResult._ScriptStructPtr != 0) ? FIEMeshQueryResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.IEMeshQueryResult", ref FIEMeshQueryResult._ScriptStructPtr);
		}

		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x060185E4 RID: 99812 RVA: 0x0023ED9C File Offset: 0x0023CF9C
		// (set) Token: 0x060185E5 RID: 99813 RVA: 0x0023EDB0 File Offset: 0x0023CFB0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UStaticMeshComponent> IEMeshComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_IEMeshComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_IEMeshComponent) = value;
			}
		}

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x060185E6 RID: 99814 RVA: 0x0023EDC5 File Offset: 0x0023CFC5
		// (set) Token: 0x060185E7 RID: 99815 RVA: 0x0023EDD9 File Offset: 0x0023CFD9
		public unsafe string IEMeshMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIEMeshQueryResult.__PropertyOffset_IEMeshMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIEMeshQueryResult.__PropertyOffset_IEMeshMessage)), value);
			}
		}

		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x060185E8 RID: 99816 RVA: 0x0023EDEE File Offset: 0x0023CFEE
		// (set) Token: 0x060185E9 RID: 99817 RVA: 0x0023EE02 File Offset: 0x0023D002
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17006144 RID: 24900
		// (get) Token: 0x060185EA RID: 99818 RVA: 0x0023EE17 File Offset: 0x0023D017
		// (set) Token: 0x060185EB RID: 99819 RVA: 0x0023EE36 File Offset: 0x0023D036
		public TSoftObjectPtr<UStaticMesh> Mesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_Mesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_Mesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006145 RID: 24901
		// (get) Token: 0x060185EC RID: 99820 RVA: 0x0023EE5B File Offset: 0x0023D05B
		// (set) Token: 0x060185ED RID: 99821 RVA: 0x0023EE6F File Offset: 0x0023D06F
		public unsafe FTransform MeshTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_MeshTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_MeshTransform) = value;
			}
		}

		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x060185EE RID: 99822 RVA: 0x0023EE84 File Offset: 0x0023D084
		// (set) Token: 0x060185EF RID: 99823 RVA: 0x0023EE94 File Offset: 0x0023D094
		public unsafe float LUTIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_LUTIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_LUTIndex) = value;
			}
		}

		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x060185F0 RID: 99824 RVA: 0x0023EEA5 File Offset: 0x0023D0A5
		// (set) Token: 0x060185F1 RID: 99825 RVA: 0x0023EEB5 File Offset: 0x0023D0B5
		public unsafe float CollisionTopZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_CollisionTopZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshQueryResult.__PropertyOffset_CollisionTopZ) = value;
			}
		}

		// Token: 0x060185F2 RID: 99826 RVA: 0x0023EEC6 File Offset: 0x0023D0C6
		public FIEMeshQueryResult()
		{
		}

		// Token: 0x060185F3 RID: 99827 RVA: 0x0023EECE File Offset: 0x0023D0CE
		public FIEMeshQueryResult([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UStaticMeshComponent> IEMeshComponent, string IEMeshMessage, FVector Location, TSoftObjectPtr<UStaticMesh> Mesh, FTransform MeshTransform, float LUTIndex, float CollisionTopZ)
		{
			this.IEMeshComponent = IEMeshComponent;
			this.IEMeshMessage = IEMeshMessage;
			this.Location = Location;
			this.Mesh = Mesh;
			this.MeshTransform = MeshTransform;
			this.LUTIndex = LUTIndex;
			this.CollisionTopZ = CollisionTopZ;
		}

		// Token: 0x060185F4 RID: 99828 RVA: 0x0023EF0B File Offset: 0x0023D10B
		protected override IntPtr GetUStructPtr()
		{
			return FIEMeshQueryResult.StaticStruct();
		}

		// Token: 0x060185F5 RID: 99829 RVA: 0x0023EF17 File Offset: 0x0023D117
		[NullableContext(2)]
		public FIEMeshQueryResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060185F6 RID: 99830 RVA: 0x0023EF21 File Offset: 0x0023D121
		public FIEMeshQueryResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060185F7 RID: 99831 RVA: 0x0023EF2C File Offset: 0x0023D12C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIEMeshQueryResult(Pointer, false, true);
		}

		// Token: 0x060185F8 RID: 99832 RVA: 0x0023EF36 File Offset: 0x0023D136
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIEMeshQueryResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2CC RID: 53964
		public const string __ObjectPath = "/Script/KuroInteractionEffect.IEMeshQueryResult";

		// Token: 0x0400D2CD RID: 53965
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2CE RID: 53966
		internal static int __PropertyOffset_IEMeshComponent;

		// Token: 0x0400D2CF RID: 53967
		internal static int __PropertyOffset_IEMeshMessage;

		// Token: 0x0400D2D0 RID: 53968
		internal static int __PropertyOffset_Location;

		// Token: 0x0400D2D1 RID: 53969
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400D2D2 RID: 53970
		internal static int __PropertyOffset_MeshTransform;

		// Token: 0x0400D2D3 RID: 53971
		internal static int __PropertyOffset_LUTIndex;

		// Token: 0x0400D2D4 RID: 53972
		internal static int __PropertyOffset_CollisionTopZ;
	}
}
