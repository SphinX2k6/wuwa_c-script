using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E87 RID: 7815
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroTerrainSurvey.CollectPropertyParams")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FCollectPropertyParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DBD4 RID: 121812 RVA: 0x002BF031 File Offset: 0x002BD231
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollectPropertyParams._ScriptStructPtr != 0) ? FCollectPropertyParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroTerrainSurvey.CollectPropertyParams", ref FCollectPropertyParams._ScriptStructPtr);
		}

		// Token: 0x17007779 RID: 30585
		// (get) Token: 0x0601DBD5 RID: 121813 RVA: 0x002BF055 File Offset: 0x002BD255
		// (set) Token: 0x0601DBD6 RID: 121814 RVA: 0x002BF06E File Offset: 0x002BD26E
		public unsafe bool bCheckOnlyCollectMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_bCheckOnlyCollectMap) & FCollectPropertyParams.__PropertyMask_bCheckOnlyCollectMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_bCheckOnlyCollectMap) = ((*(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_bCheckOnlyCollectMap) & ~FCollectPropertyParams.__PropertyMask_bCheckOnlyCollectMap) | (value ? FCollectPropertyParams.__PropertyMask_bCheckOnlyCollectMap : 0));
			}
		}

		// Token: 0x1700777A RID: 30586
		// (get) Token: 0x0601DBD7 RID: 121815 RVA: 0x002BF0A0 File Offset: 0x002BD2A0
		// (set) Token: 0x0601DBD8 RID: 121816 RVA: 0x002BF0E3 File Offset: 0x002BD2E3
		public TMap<FName, FKTSPT_CopyPropertyData> CollectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKTSPT_CopyPropertyData> result;
				if ((result = this._CollectMap) == null)
				{
					result = (this._CollectMap = new TMap<FName, FKTSPT_CopyPropertyData>(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_CollectMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CollectMap.CopyAssign(value);
			}
		}

		// Token: 0x1700777B RID: 30587
		// (get) Token: 0x0601DBD9 RID: 121817 RVA: 0x002BF0F4 File Offset: 0x002BD2F4
		// (set) Token: 0x0601DBDA RID: 121818 RVA: 0x002BF137 File Offset: 0x002BD337
		public TMap<FName, FKTSPT_CopyPropertyData> IgnorePropertyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKTSPT_CopyPropertyData> result;
				if ((result = this._IgnorePropertyMap) == null)
				{
					result = (this._IgnorePropertyMap = new TMap<FName, FKTSPT_CopyPropertyData>(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_IgnorePropertyMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IgnorePropertyMap.CopyAssign(value);
			}
		}

		// Token: 0x1700777C RID: 30588
		// (get) Token: 0x0601DBDB RID: 121819 RVA: 0x002BF145 File Offset: 0x002BD345
		// (set) Token: 0x0601DBDC RID: 121820 RVA: 0x002BF159 File Offset: 0x002BD359
		public unsafe UClassStackOnlyPtr ParentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_ParentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_ParentClass) = value;
			}
		}

		// Token: 0x1700777D RID: 30589
		// (get) Token: 0x0601DBDD RID: 121821 RVA: 0x002BF16E File Offset: 0x002BD36E
		// (set) Token: 0x0601DBDE RID: 121822 RVA: 0x002BF187 File Offset: 0x002BD387
		public unsafe bool bCheckOnlyNative
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_bCheckOnlyNative) & FCollectPropertyParams.__PropertyMask_bCheckOnlyNative) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_bCheckOnlyNative) = ((*(base.NativePtr + (IntPtr)FCollectPropertyParams.__PropertyOffset_bCheckOnlyNative) & ~FCollectPropertyParams.__PropertyMask_bCheckOnlyNative) | (value ? FCollectPropertyParams.__PropertyMask_bCheckOnlyNative : 0));
			}
		}

		// Token: 0x0601DBDF RID: 121823 RVA: 0x002BF1B7 File Offset: 0x002BD3B7
		public FCollectPropertyParams()
		{
		}

		// Token: 0x0601DBE0 RID: 121824 RVA: 0x002BF1BF File Offset: 0x002BD3BF
		public FCollectPropertyParams(bool bCheckOnlyCollectMap, TMap<FName, FKTSPT_CopyPropertyData> CollectMap, TMap<FName, FKTSPT_CopyPropertyData> IgnorePropertyMap, UClassStackOnlyPtr ParentClass, bool bCheckOnlyNative)
		{
			this.bCheckOnlyCollectMap = bCheckOnlyCollectMap;
			this.CollectMap = CollectMap;
			this.IgnorePropertyMap = IgnorePropertyMap;
			this.ParentClass = ParentClass;
			this.bCheckOnlyNative = bCheckOnlyNative;
		}

		// Token: 0x0601DBE1 RID: 121825 RVA: 0x002BF1EC File Offset: 0x002BD3EC
		protected override IntPtr GetUStructPtr()
		{
			return FCollectPropertyParams.StaticStruct();
		}

		// Token: 0x0601DBE2 RID: 121826 RVA: 0x002BF1F8 File Offset: 0x002BD3F8
		[NullableContext(2)]
		public FCollectPropertyParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBE3 RID: 121827 RVA: 0x002BF202 File Offset: 0x002BD402
		public FCollectPropertyParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBE4 RID: 121828 RVA: 0x002BF20D File Offset: 0x002BD40D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollectPropertyParams(Pointer, false, true);
		}

		// Token: 0x0601DBE5 RID: 121829 RVA: 0x002BF217 File Offset: 0x002BD417
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollectPropertyParams(Pointer, MemoryOwner);
		}

		// Token: 0x040101A3 RID: 65955
		public const string __ObjectPath = "/Script/KuroTerrainSurvey.CollectPropertyParams";

		// Token: 0x040101A4 RID: 65956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040101A5 RID: 65957
		internal static int __PropertyOffset_bCheckOnlyCollectMap;

		// Token: 0x040101A6 RID: 65958
		internal static byte __PropertyMask_bCheckOnlyCollectMap;

		// Token: 0x040101A7 RID: 65959
		internal static int __PropertyOffset_CollectMap;

		// Token: 0x040101A8 RID: 65960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKTSPT_CopyPropertyData> _CollectMap;

		// Token: 0x040101A9 RID: 65961
		internal static int __PropertyOffset_IgnorePropertyMap;

		// Token: 0x040101AA RID: 65962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKTSPT_CopyPropertyData> _IgnorePropertyMap;

		// Token: 0x040101AB RID: 65963
		internal static int __PropertyOffset_ParentClass;

		// Token: 0x040101AC RID: 65964
		internal static int __PropertyOffset_bCheckOnlyNative;

		// Token: 0x040101AD RID: 65965
		internal static byte __PropertyMask_bCheckOnlyNative;
	}
}
