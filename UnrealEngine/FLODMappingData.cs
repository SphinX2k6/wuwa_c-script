using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D67 RID: 3431
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LODMappingData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLODMappingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B95C RID: 47452 RVA: 0x00107BE7 File Offset: 0x00105DE7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLODMappingData._ScriptStructPtr != 0) ? FLODMappingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LODMappingData", ref FLODMappingData._ScriptStructPtr);
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x00107C0C File Offset: 0x00105E0C
		// (set) Token: 0x0600B95E RID: 47454 RVA: 0x00107C4F File Offset: 0x00105E4F
		public TArray<int> Mapping
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Mapping) == null)
				{
					result = (this._Mapping = new TArray<int>(base.NativePtr + (IntPtr)FLODMappingData.__PropertyOffset_Mapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Mapping.CopyAssign(value);
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x00107C60 File Offset: 0x00105E60
		// (set) Token: 0x0600B960 RID: 47456 RVA: 0x00107CA3 File Offset: 0x00105EA3
		public TArray<int> InverseMapping
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InverseMapping) == null)
				{
					result = (this._InverseMapping = new TArray<int>(base.NativePtr + (IntPtr)FLODMappingData.__PropertyOffset_InverseMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InverseMapping.CopyAssign(value);
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x00107CB1 File Offset: 0x00105EB1
		public FLODMappingData()
		{
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x00107CB9 File Offset: 0x00105EB9
		public FLODMappingData(TArray<int> Mapping, TArray<int> InverseMapping)
		{
			this.Mapping = Mapping;
			this.InverseMapping = InverseMapping;
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x00107CCF File Offset: 0x00105ECF
		protected override IntPtr GetUStructPtr()
		{
			return FLODMappingData.StaticStruct();
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x00107CDB File Offset: 0x00105EDB
		[NullableContext(2)]
		public FLODMappingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x00107CE5 File Offset: 0x00105EE5
		public FLODMappingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x00107CF0 File Offset: 0x00105EF0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLODMappingData(Pointer, false, true);
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x00107CFA File Offset: 0x00105EFA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLODMappingData(Pointer, MemoryOwner);
		}

		// Token: 0x0400611F RID: 24863
		public const string __ObjectPath = "/Script/Engine.LODMappingData";

		// Token: 0x04006120 RID: 24864
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006121 RID: 24865
		internal static int __PropertyOffset_Mapping;

		// Token: 0x04006122 RID: 24866
		[Nullable(2)]
		private TArray<int> _Mapping;

		// Token: 0x04006123 RID: 24867
		internal static int __PropertyOffset_InverseMapping;

		// Token: 0x04006124 RID: 24868
		[Nullable(2)]
		private TArray<int> _InverseMapping;
	}
}
