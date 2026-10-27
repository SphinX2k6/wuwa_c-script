using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002101 RID: 8449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.RootTextItemMapDataV2")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class URootTextItemMapDataV2 : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FCA4 RID: 130212 RVA: 0x002F45F4 File Offset: 0x002F27F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URootTextItemMapDataV2._ClassPtr;
		}

		// Token: 0x0601FCA5 RID: 130213 RVA: 0x002F4600 File Offset: 0x002F2800
		public URootTextItemMapDataV2() : this(BuiltinUtils.AllocNativeUObject(URootTextItemMapDataV2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FCA6 RID: 130214 RVA: 0x002F4628 File Offset: 0x002F2828
		public URootTextItemMapDataV2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URootTextItemMapDataV2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D0F RID: 32015
		// (get) Token: 0x0601FCA7 RID: 130215 RVA: 0x002F465C File Offset: 0x002F285C
		// (set) Token: 0x0601FCA8 RID: 130216 RVA: 0x002F4695 File Offset: 0x002F2895
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<uint, TWeakObjectPtr<AUITextActor>> TextActorMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<uint, TWeakObjectPtr<AUITextActor>> result;
				if ((result = this._TextActorMap) == null)
				{
					result = (this._TextActorMap = new TMap<uint, TWeakObjectPtr<AUITextActor>>(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_TextActorMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.TextActorMap.CopyAssign(value);
			}
		}

		// Token: 0x17007D10 RID: 32016
		// (get) Token: 0x0601FCA9 RID: 130217 RVA: 0x002F46A4 File Offset: 0x002F28A4
		// (set) Token: 0x0601FCAA RID: 130218 RVA: 0x002F46DD File Offset: 0x002F28DD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<uint, TWeakObjectPtr<AUITextActor>> DirtyTextActorMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<uint, TWeakObjectPtr<AUITextActor>> result;
				if ((result = this._DirtyTextActorMap) == null)
				{
					result = (this._DirtyTextActorMap = new TMap<uint, TWeakObjectPtr<AUITextActor>>(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_DirtyTextActorMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DirtyTextActorMap.CopyAssign(value);
			}
		}

		// Token: 0x17007D11 RID: 32017
		// (get) Token: 0x0601FCAB RID: 130219 RVA: 0x002F46EC File Offset: 0x002F28EC
		// (set) Token: 0x0601FCAC RID: 130220 RVA: 0x002F4725 File Offset: 0x002F2925
		public TMap<uint, uint> TransitionTextIdMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<uint, uint> result;
				if ((result = this._TransitionTextIdMap) == null)
				{
					result = (this._TransitionTextIdMap = new TMap<uint, uint>(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_TransitionTextIdMap, this));
				}
				return result;
			}
			set
			{
				this.TransitionTextIdMap.CopyAssign(value);
			}
		}

		// Token: 0x17007D12 RID: 32018
		// (get) Token: 0x0601FCAD RID: 130221 RVA: 0x002F4733 File Offset: 0x002F2933
		// (set) Token: 0x0601FCAE RID: 130222 RVA: 0x002F4743 File Offset: 0x002F2943
		public unsafe bool bUnpackAllText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_bUnpackAllText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_bUnpackAllText) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D13 RID: 32019
		// (get) Token: 0x0601FCAF RID: 130223 RVA: 0x002F4754 File Offset: 0x002F2954
		// (set) Token: 0x0601FCB0 RID: 130224 RVA: 0x002F4764 File Offset: 0x002F2964
		public unsafe bool bIsPartOfNested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_bIsPartOfNested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URootTextItemMapDataV2.__PropertyOffset_bIsPartOfNested) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FCB1 RID: 130225 RVA: 0x002F4775 File Offset: 0x002F2975
		static URootTextItemMapDataV2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.RootTextItemMapDataV2");
		}

		// Token: 0x0601FCB2 RID: 130226 RVA: 0x002F4783 File Offset: 0x002F2983
		protected URootTextItemMapDataV2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401121D RID: 70173
		public new const string __ObjectPath = "/Script/LGUI.RootTextItemMapDataV2";

		// Token: 0x0401121E RID: 70174
		private static IntPtr _ClassPtr;

		// Token: 0x0401121F RID: 70175
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011220 RID: 70176
		internal static int __PropertyOffset_TextActorMap;

		// Token: 0x04011221 RID: 70177
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<uint, TWeakObjectPtr<AUITextActor>> _TextActorMap;

		// Token: 0x04011222 RID: 70178
		internal static int __PropertyOffset_DirtyTextActorMap;

		// Token: 0x04011223 RID: 70179
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<uint, TWeakObjectPtr<AUITextActor>> _DirtyTextActorMap;

		// Token: 0x04011224 RID: 70180
		internal static int __PropertyOffset_TransitionTextIdMap;

		// Token: 0x04011225 RID: 70181
		[Nullable(2)]
		private TMap<uint, uint> _TransitionTextIdMap;

		// Token: 0x04011226 RID: 70182
		internal static int __PropertyOffset_bUnpackAllText;

		// Token: 0x04011227 RID: 70183
		internal static int __PropertyOffset_bIsPartOfNested;
	}
}
