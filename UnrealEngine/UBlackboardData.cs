using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000122 RID: 290
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BlackboardData")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UBlackboardData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001535 RID: 5429 RVA: 0x0001F2AC File Offset: 0x0001D4AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardData._ClassPtr;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		public UBlackboardData() : this(BuiltinUtils.AllocNativeUObject(UBlackboardData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
		public UBlackboardData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0001F313 File Offset: 0x0001D513
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x0001F327 File Offset: 0x0001D527
		[Nullable(2)]
		public unsafe UBlackboardData Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardData>(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardData.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardData.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0001F33C File Offset: 0x0001D53C
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x0001F375 File Offset: 0x0001D575
		public TArray<FBlackboardEntry> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlackboardEntry> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<FBlackboardEntry>(base.NativePtr + (IntPtr)UBlackboardData.__PropertyOffset_Keys, this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0001F383 File Offset: 0x0001D583
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x0001F39C File Offset: 0x0001D59C
		public unsafe bool bHasSynchronizedKeys
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlackboardData.__PropertyOffset_bHasSynchronizedKeys) & UBlackboardData.__PropertyMask_bHasSynchronizedKeys) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlackboardData.__PropertyOffset_bHasSynchronizedKeys) = ((*(base.NativePtr + (IntPtr)UBlackboardData.__PropertyOffset_bHasSynchronizedKeys) & ~UBlackboardData.__PropertyMask_bHasSynchronizedKeys) | (value ? UBlackboardData.__PropertyMask_bHasSynchronizedKeys : 0));
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		static UBlackboardData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardData");
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0001F3DA File Offset: 0x0001D5DA
		protected UBlackboardData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000469 RID: 1129
		public new const string __ObjectPath = "/Script/AIModule.BlackboardData";

		// Token: 0x0400046A RID: 1130
		private static IntPtr _ClassPtr;

		// Token: 0x0400046B RID: 1131
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400046C RID: 1132
		internal static int __PropertyOffset_Parent;

		// Token: 0x0400046D RID: 1133
		internal static int __PropertyOffset_Keys;

		// Token: 0x0400046E RID: 1134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlackboardEntry> _Keys;

		// Token: 0x0400046F RID: 1135
		internal static int __PropertyOffset_bHasSynchronizedKeys;

		// Token: 0x04000470 RID: 1136
		internal static byte __PropertyMask_bHasSynchronizedKeys;
	}
}
