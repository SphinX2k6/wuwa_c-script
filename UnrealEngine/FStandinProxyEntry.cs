using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028C2 RID: 10434
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StandinActor.StandinProxyEntry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FStandinProxyEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026BD3 RID: 158675 RVA: 0x003B194A File Offset: 0x003AFB4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStandinProxyEntry._ScriptStructPtr != 0) ? FStandinProxyEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/StandinActor.StandinProxyEntry", ref FStandinProxyEntry._ScriptStructPtr);
		}

		// Token: 0x17009541 RID: 38209
		// (get) Token: 0x06026BD4 RID: 158676 RVA: 0x003B196E File Offset: 0x003AFB6E
		// (set) Token: 0x06026BD5 RID: 158677 RVA: 0x003B1982 File Offset: 0x003AFB82
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<AStandInMeshActor> StandinActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FStandinProxyEntry.__PropertyOffset_StandinActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FStandinProxyEntry.__PropertyOffset_StandinActor) = value;
			}
		}

		// Token: 0x17009542 RID: 38210
		// (get) Token: 0x06026BD6 RID: 158678 RVA: 0x003B1997 File Offset: 0x003AFB97
		// (set) Token: 0x06026BD7 RID: 158679 RVA: 0x003B19AB File Offset: 0x003AFBAB
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FStandinProxyEntry.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStandinProxyEntry.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17009543 RID: 38211
		// (get) Token: 0x06026BD8 RID: 158680 RVA: 0x003B19C0 File Offset: 0x003AFBC0
		// (set) Token: 0x06026BD9 RID: 158681 RVA: 0x003B19D4 File Offset: 0x003AFBD4
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FStandinProxyEntry.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStandinProxyEntry.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17009544 RID: 38212
		// (get) Token: 0x06026BDA RID: 158682 RVA: 0x003B19EC File Offset: 0x003AFBEC
		// (set) Token: 0x06026BDB RID: 158683 RVA: 0x003B1A2F File Offset: 0x003AFC2F
		public TArray<UTexture2D> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)FStandinProxyEntry.__PropertyOffset_Textures, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x17009545 RID: 38213
		// (get) Token: 0x06026BDC RID: 158684 RVA: 0x003B1A3D File Offset: 0x003AFC3D
		// (set) Token: 0x06026BDD RID: 158685 RVA: 0x003B1A51 File Offset: 0x003AFC51
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStandinProxyEntry.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStandinProxyEntry.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x06026BDE RID: 158686 RVA: 0x003B1A66 File Offset: 0x003AFC66
		public FStandinProxyEntry()
		{
		}

		// Token: 0x06026BDF RID: 158687 RVA: 0x003B1A6E File Offset: 0x003AFC6E
		public FStandinProxyEntry([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<AStandInMeshActor> StandinActor, UStaticMesh StaticMesh, UMaterialInterface Material, TArray<UTexture2D> Textures, FName Key)
		{
			this.StandinActor = StandinActor;
			this.StaticMesh = StaticMesh;
			this.Material = Material;
			this.Textures = Textures;
			this.Key = Key;
		}

		// Token: 0x06026BE0 RID: 158688 RVA: 0x003B1A9B File Offset: 0x003AFC9B
		protected override IntPtr GetUStructPtr()
		{
			return FStandinProxyEntry.StaticStruct();
		}

		// Token: 0x06026BE1 RID: 158689 RVA: 0x003B1AA7 File Offset: 0x003AFCA7
		[NullableContext(2)]
		public FStandinProxyEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026BE2 RID: 158690 RVA: 0x003B1AB1 File Offset: 0x003AFCB1
		public FStandinProxyEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026BE3 RID: 158691 RVA: 0x003B1ABC File Offset: 0x003AFCBC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStandinProxyEntry(Pointer, false, true);
		}

		// Token: 0x06026BE4 RID: 158692 RVA: 0x003B1AC6 File Offset: 0x003AFCC6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStandinProxyEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04015427 RID: 87079
		public const string __ObjectPath = "/Script/StandinActor.StandinProxyEntry";

		// Token: 0x04015428 RID: 87080
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015429 RID: 87081
		internal static int __PropertyOffset_StandinActor;

		// Token: 0x0401542A RID: 87082
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0401542B RID: 87083
		internal static int __PropertyOffset_Material;

		// Token: 0x0401542C RID: 87084
		internal static int __PropertyOffset_Textures;

		// Token: 0x0401542D RID: 87085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _Textures;

		// Token: 0x0401542E RID: 87086
		internal static int __PropertyOffset_Key;
	}
}
