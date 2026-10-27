using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010E0 RID: 4320
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SectionExtraMaterialMap")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSectionExtraMaterialMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F7C0 RID: 63424 RVA: 0x0016EA24 File Offset: 0x0016CC24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSectionExtraMaterialMap._ScriptStructPtr != 0) ? FSectionExtraMaterialMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SectionExtraMaterialMap", ref FSectionExtraMaterialMap._ScriptStructPtr);
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600F7C1 RID: 63425 RVA: 0x0016EA48 File Offset: 0x0016CC48
		// (set) Token: 0x0600F7C2 RID: 63426 RVA: 0x0016EA8B File Offset: 0x0016CC8B
		public TArray<int> MaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaterialMap) == null)
				{
					result = (this._MaterialMap = new TArray<int>(base.NativePtr + (IntPtr)FSectionExtraMaterialMap.__PropertyOffset_MaterialMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x0016EA99 File Offset: 0x0016CC99
		public FSectionExtraMaterialMap()
		{
		}

		// Token: 0x0600F7C4 RID: 63428 RVA: 0x0016EAA1 File Offset: 0x0016CCA1
		public FSectionExtraMaterialMap(TArray<int> MaterialMap)
		{
			this.MaterialMap = MaterialMap;
		}

		// Token: 0x0600F7C5 RID: 63429 RVA: 0x0016EAB0 File Offset: 0x0016CCB0
		protected override IntPtr GetUStructPtr()
		{
			return FSectionExtraMaterialMap.StaticStruct();
		}

		// Token: 0x0600F7C6 RID: 63430 RVA: 0x0016EABC File Offset: 0x0016CCBC
		[NullableContext(2)]
		public FSectionExtraMaterialMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F7C7 RID: 63431 RVA: 0x0016EAC6 File Offset: 0x0016CCC6
		public FSectionExtraMaterialMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F7C8 RID: 63432 RVA: 0x0016EAD1 File Offset: 0x0016CCD1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSectionExtraMaterialMap(Pointer, false, true);
		}

		// Token: 0x0600F7C9 RID: 63433 RVA: 0x0016EADB File Offset: 0x0016CCDB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSectionExtraMaterialMap(Pointer, MemoryOwner);
		}

		// Token: 0x040085E0 RID: 34272
		public const string __ObjectPath = "/Script/Engine.SectionExtraMaterialMap";

		// Token: 0x040085E1 RID: 34273
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040085E2 RID: 34274
		internal static int __PropertyOffset_MaterialMap;

		// Token: 0x040085E3 RID: 34275
		[Nullable(2)]
		private TArray<int> _MaterialMap;
	}
}
