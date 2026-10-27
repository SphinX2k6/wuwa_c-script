using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200168E RID: 5774
	[UnrealObjectPath("/Script/KuroAudioMaterial.KuroMatName2PhysMaterial")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroMatName2PhysMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014F41 RID: 85825 RVA: 0x001ECD96 File Offset: 0x001EAF96
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMatName2PhysMaterial._ScriptStructPtr != 0) ? FKuroMatName2PhysMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAudioMaterial.KuroMatName2PhysMaterial", ref FKuroMatName2PhysMaterial._ScriptStructPtr);
		}

		// Token: 0x17005305 RID: 21253
		// (get) Token: 0x06014F42 RID: 85826 RVA: 0x001ECDBA File Offset: 0x001EAFBA
		// (set) Token: 0x06014F43 RID: 85827 RVA: 0x001ECDCE File Offset: 0x001EAFCE
		public unsafe FName MaterialName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMatName2PhysMaterial.__PropertyOffset_MaterialName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMatName2PhysMaterial.__PropertyOffset_MaterialName) = value;
			}
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x06014F44 RID: 85828 RVA: 0x001ECDE3 File Offset: 0x001EAFE3
		// (set) Token: 0x06014F45 RID: 85829 RVA: 0x001ECDF7 File Offset: 0x001EAFF7
		public unsafe FName PhysicalMaterialName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMatName2PhysMaterial.__PropertyOffset_PhysicalMaterialName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMatName2PhysMaterial.__PropertyOffset_PhysicalMaterialName) = value;
			}
		}

		// Token: 0x06014F46 RID: 85830 RVA: 0x001ECE0C File Offset: 0x001EB00C
		public FKuroMatName2PhysMaterial()
		{
		}

		// Token: 0x06014F47 RID: 85831 RVA: 0x001ECE14 File Offset: 0x001EB014
		public FKuroMatName2PhysMaterial(FName MaterialName, FName PhysicalMaterialName)
		{
			this.MaterialName = MaterialName;
			this.PhysicalMaterialName = PhysicalMaterialName;
		}

		// Token: 0x06014F48 RID: 85832 RVA: 0x001ECE2A File Offset: 0x001EB02A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMatName2PhysMaterial.StaticStruct();
		}

		// Token: 0x06014F49 RID: 85833 RVA: 0x001ECE36 File Offset: 0x001EB036
		[NullableContext(2)]
		public FKuroMatName2PhysMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014F4A RID: 85834 RVA: 0x001ECE40 File Offset: 0x001EB040
		public FKuroMatName2PhysMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014F4B RID: 85835 RVA: 0x001ECE4B File Offset: 0x001EB04B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMatName2PhysMaterial(Pointer, false, true);
		}

		// Token: 0x06014F4C RID: 85836 RVA: 0x001ECE55 File Offset: 0x001EB055
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMatName2PhysMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x0400B69D RID: 46749
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudioMaterial.KuroMatName2PhysMaterial";

		// Token: 0x0400B69E RID: 46750
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B69F RID: 46751
		internal static int __PropertyOffset_MaterialName;

		// Token: 0x0400B6A0 RID: 46752
		internal static int __PropertyOffset_PhysicalMaterialName;
	}
}
