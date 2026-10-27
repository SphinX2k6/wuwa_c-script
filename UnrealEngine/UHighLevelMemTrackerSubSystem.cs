using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C20 RID: 3104
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HighLevelMemTrackerSubSystem")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UHighLevelMemTrackerSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009D3A RID: 40250 RVA: 0x000DF994 File Offset: 0x000DDB94
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHighLevelMemTrackerSubSystem._ClassPtr;
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x000DF9A0 File Offset: 0x000DDBA0
		public UHighLevelMemTrackerSubSystem() : this(BuiltinUtils.AllocNativeUObject(UHighLevelMemTrackerSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x000DF9C8 File Offset: 0x000DDBC8
		[NullableContext(1)]
		public UHighLevelMemTrackerSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHighLevelMemTrackerSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x000DF9FB File Offset: 0x000DDBFB
		// (set) Token: 0x06009D3E RID: 40254 RVA: 0x000DFA0B File Offset: 0x000DDC0B
		public unsafe int CheckCellNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CheckCellNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CheckCellNum) = value;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x000DFA1C File Offset: 0x000DDC1C
		// (set) Token: 0x06009D40 RID: 40256 RVA: 0x000DFA2C File Offset: 0x000DDC2C
		public unsafe float StepSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeX) = value;
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x06009D41 RID: 40257 RVA: 0x000DFA3D File Offset: 0x000DDC3D
		// (set) Token: 0x06009D42 RID: 40258 RVA: 0x000DFA4D File Offset: 0x000DDC4D
		public unsafe float StepSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeY) = value;
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x06009D43 RID: 40259 RVA: 0x000DFA5E File Offset: 0x000DDC5E
		// (set) Token: 0x06009D44 RID: 40260 RVA: 0x000DFA6E File Offset: 0x000DDC6E
		public unsafe float StepSizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeZ) = value;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x06009D45 RID: 40261 RVA: 0x000DFA7F File Offset: 0x000DDC7F
		// (set) Token: 0x06009D46 RID: 40262 RVA: 0x000DFA93 File Offset: 0x000DDC93
		public unsafe AActor StreamingSourceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UHighLevelMemTrackerSubSystem.__PropertyOffset_StreamingSourceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHighLevelMemTrackerSubSystem.__PropertyOffset_StreamingSourceActor, value);
			}
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x06009D47 RID: 40263 RVA: 0x000DFAA8 File Offset: 0x000DDCA8
		// (set) Token: 0x06009D48 RID: 40264 RVA: 0x000DFAB8 File Offset: 0x000DDCB8
		public unsafe int ProcessMemoryThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ProcessMemoryThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ProcessMemoryThresholds) = value;
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x06009D49 RID: 40265 RVA: 0x000DFAC9 File Offset: 0x000DDCC9
		// (set) Token: 0x06009D4A RID: 40266 RVA: 0x000DFAD9 File Offset: 0x000DDCD9
		public unsafe int OneCellMemoryThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_OneCellMemoryThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_OneCellMemoryThresholds) = value;
			}
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x06009D4B RID: 40267 RVA: 0x000DFAEA File Offset: 0x000DDCEA
		// (set) Token: 0x06009D4C RID: 40268 RVA: 0x000DFAFA File Offset: 0x000DDCFA
		public unsafe int CellLoadingThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CellLoadingThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CellLoadingThresholds) = value;
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x06009D4D RID: 40269 RVA: 0x000DFB0B File Offset: 0x000DDD0B
		// (set) Token: 0x06009D4E RID: 40270 RVA: 0x000DFB1B File Offset: 0x000DDD1B
		public unsafe int ActorMemoryThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ActorMemoryThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ActorMemoryThresholds) = value;
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x000DFB2C File Offset: 0x000DDD2C
		// (set) Token: 0x06009D50 RID: 40272 RVA: 0x000DFB3C File Offset: 0x000DDD3C
		public unsafe int SequenceThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_SequenceThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_SequenceThresholds) = value;
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x000DFB50 File Offset: 0x000DDD50
		// (set) Token: 0x06009D52 RID: 40274 RVA: 0x000DFB89 File Offset: 0x000DDD89
		[Nullable(1)]
		public FKuroRunMapTickDelegate RunMapTickCallBack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroRunMapTickDelegate result;
				if ((result = this._RunMapTickCallBack) == null)
				{
					result = (this._RunMapTickCallBack = new FKuroRunMapTickDelegate(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_RunMapTickCallBack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_RunMapTickCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x000DFBAA File Offset: 0x000DDDAA
		public void SetOpenFlag(bool bFlag)
		{
			UHighLevelMemTrackerSubSystem.__SetOpenFlag_Internal(base.NativePtr, bFlag);
		}

		// Token: 0x06009D54 RID: 40276 RVA: 0x000DFBB8 File Offset: 0x000DDDB8
		public bool IsRunFinish()
		{
			return UHighLevelMemTrackerSubSystem.__IsRunFinish_Internal(base.NativePtr);
		}

		// Token: 0x06009D55 RID: 40277 RVA: 0x000DFBC5 File Offset: 0x000DDDC5
		public static UHighLevelMemTrackerSubSystem GetSubSystem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UHighLevelMemTrackerSubSystem>(UHighLevelMemTrackerSubSystem.__GetSubSystem_Internal());
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x000DFBD1 File Offset: 0x000DDDD1
		public void CheckMemory()
		{
			UHighLevelMemTrackerSubSystem.__CheckMemory_Internal(base.NativePtr);
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x000DFBDE File Offset: 0x000DDDDE
		public bool CalculateMapBounds()
		{
			return UHighLevelMemTrackerSubSystem.__CalculateMapBounds_Internal(base.NativePtr);
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x000DFBEB File Offset: 0x000DDDEB
		public bool AutoRunMap(AActor Actor)
		{
			return UHighLevelMemTrackerSubSystem.__AutoRunMap_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009D59 RID: 40281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOpenFlag_Internal(IntPtr @this, bool bFlag);

		// Token: 0x06009D5A RID: 40282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRunFinish_Internal(IntPtr @this);

		// Token: 0x06009D5B RID: 40283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubSystem_Internal();

		// Token: 0x06009D5C RID: 40284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckMemory_Internal(IntPtr @this);

		// Token: 0x06009D5D RID: 40285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CalculateMapBounds_Internal(IntPtr @this);

		// Token: 0x06009D5E RID: 40286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AutoRunMap_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06009D5F RID: 40287 RVA: 0x000DFC08 File Offset: 0x000DDE08
		static UHighLevelMemTrackerSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HighLevelMemTrackerSubSystem");
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x000DFC16 File Offset: 0x000DDE16
		protected UHighLevelMemTrackerSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040056C5 RID: 22213
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HighLevelMemTrackerSubSystem";

		// Token: 0x040056C6 RID: 22214
		private static IntPtr _ClassPtr;

		// Token: 0x040056C7 RID: 22215
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040056C8 RID: 22216
		internal static int __PropertyOffset_CheckCellNum;

		// Token: 0x040056C9 RID: 22217
		internal static int __PropertyOffset_StepSizeX;

		// Token: 0x040056CA RID: 22218
		internal static int __PropertyOffset_StepSizeY;

		// Token: 0x040056CB RID: 22219
		internal static int __PropertyOffset_StepSizeZ;

		// Token: 0x040056CC RID: 22220
		internal static int __PropertyOffset_StreamingSourceActor;

		// Token: 0x040056CD RID: 22221
		internal static int __PropertyOffset_ProcessMemoryThresholds;

		// Token: 0x040056CE RID: 22222
		internal static int __PropertyOffset_OneCellMemoryThresholds;

		// Token: 0x040056CF RID: 22223
		internal static int __PropertyOffset_CellLoadingThresholds;

		// Token: 0x040056D0 RID: 22224
		internal static int __PropertyOffset_ActorMemoryThresholds;

		// Token: 0x040056D1 RID: 22225
		internal static int __PropertyOffset_SequenceThresholds;

		// Token: 0x040056D2 RID: 22226
		internal static int __PropertyOffset_RunMapTickCallBack;

		// Token: 0x040056D3 RID: 22227
		private FKuroRunMapTickDelegate _RunMapTickCallBack;
	}
}
