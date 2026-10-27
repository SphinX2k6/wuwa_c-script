using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E96 RID: 3734
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialRemapIndex")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMaterialRemapIndex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C91A RID: 51482 RVA: 0x00124CCC File Offset: 0x00122ECC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialRemapIndex._ScriptStructPtr != 0) ? FMaterialRemapIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialRemapIndex", ref FMaterialRemapIndex._ScriptStructPtr);
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600C91B RID: 51483 RVA: 0x00124CF0 File Offset: 0x00122EF0
		// (set) Token: 0x0600C91C RID: 51484 RVA: 0x00124D00 File Offset: 0x00122F00
		public unsafe uint ImportVersionKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialRemapIndex.__PropertyOffset_ImportVersionKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialRemapIndex.__PropertyOffset_ImportVersionKey) = (int)value;
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600C91D RID: 51485 RVA: 0x00124D14 File Offset: 0x00122F14
		// (set) Token: 0x0600C91E RID: 51486 RVA: 0x00124D57 File Offset: 0x00122F57
		public TArray<int> MaterialRemap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaterialRemap) == null)
				{
					result = (this._MaterialRemap = new TArray<int>(base.NativePtr + (IntPtr)FMaterialRemapIndex.__PropertyOffset_MaterialRemap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialRemap.CopyAssign(value);
			}
		}

		// Token: 0x0600C91F RID: 51487 RVA: 0x00124D65 File Offset: 0x00122F65
		public FMaterialRemapIndex()
		{
		}

		// Token: 0x0600C920 RID: 51488 RVA: 0x00124D6D File Offset: 0x00122F6D
		public FMaterialRemapIndex(uint ImportVersionKey, TArray<int> MaterialRemap)
		{
			this.ImportVersionKey = ImportVersionKey;
			this.MaterialRemap = MaterialRemap;
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x00124D83 File Offset: 0x00122F83
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialRemapIndex.StaticStruct();
		}

		// Token: 0x0600C922 RID: 51490 RVA: 0x00124D8F File Offset: 0x00122F8F
		[NullableContext(2)]
		public FMaterialRemapIndex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x00124D99 File Offset: 0x00122F99
		public FMaterialRemapIndex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x00124DA4 File Offset: 0x00122FA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialRemapIndex(Pointer, false, true);
		}

		// Token: 0x0600C925 RID: 51493 RVA: 0x00124DAE File Offset: 0x00122FAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialRemapIndex(Pointer, MemoryOwner);
		}

		// Token: 0x04006C3A RID: 27706
		public const string __ObjectPath = "/Script/Engine.MaterialRemapIndex";

		// Token: 0x04006C3B RID: 27707
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006C3C RID: 27708
		internal static int __PropertyOffset_ImportVersionKey;

		// Token: 0x04006C3D RID: 27709
		internal static int __PropertyOffset_MaterialRemap;

		// Token: 0x04006C3E RID: 27710
		[Nullable(2)]
		private TArray<int> _MaterialRemap;
	}
}
