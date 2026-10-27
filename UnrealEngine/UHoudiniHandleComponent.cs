using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014C5 RID: 5317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniHandleComponent")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UHoudiniHandleComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013401 RID: 78849 RVA: 0x001C4EE4 File Offset: 0x001C30E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniHandleComponent._ClassPtr;
		}

		// Token: 0x06013402 RID: 78850 RVA: 0x001C4EF0 File Offset: 0x001C30F0
		public UHoudiniHandleComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniHandleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013403 RID: 78851 RVA: 0x001C4F18 File Offset: 0x001C3118
		public UHoudiniHandleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniHandleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x06013404 RID: 78852 RVA: 0x001C4F4C File Offset: 0x001C314C
		// (set) Token: 0x06013405 RID: 78853 RVA: 0x001C4F85 File Offset: 0x001C3185
		public TArray<UHoudiniHandleParameter> XformParms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniHandleParameter> result;
				if ((result = this._XformParms) == null)
				{
					result = (this._XformParms = new TArray<UHoudiniHandleParameter>(base.NativePtr + (IntPtr)UHoudiniHandleComponent.__PropertyOffset_XformParms, this));
				}
				return result;
			}
			set
			{
				this.XformParms.CopyAssign(value);
			}
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x06013406 RID: 78854 RVA: 0x001C4F93 File Offset: 0x001C3193
		// (set) Token: 0x06013407 RID: 78855 RVA: 0x001C4FA7 File Offset: 0x001C31A7
		[Nullable(2)]
		public unsafe UHoudiniHandleParameter RSTParm
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniHandleParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniHandleComponent.__PropertyOffset_RSTParm);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniHandleComponent.__PropertyOffset_RSTParm, value);
			}
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x06013408 RID: 78856 RVA: 0x001C4FBC File Offset: 0x001C31BC
		// (set) Token: 0x06013409 RID: 78857 RVA: 0x001C4FD0 File Offset: 0x001C31D0
		[Nullable(2)]
		public unsafe UHoudiniHandleParameter RotOrderParm
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniHandleParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniHandleComponent.__PropertyOffset_RotOrderParm);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniHandleComponent.__PropertyOffset_RotOrderParm, value);
			}
		}

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x0601340A RID: 78858 RVA: 0x001C4FE5 File Offset: 0x001C31E5
		// (set) Token: 0x0601340B RID: 78859 RVA: 0x001C4FF5 File Offset: 0x001C31F5
		public unsafe EHoudiniHandleType HandleType
		{
			get
			{
				return (EHoudiniHandleType)(*(base.NativePtr + (IntPtr)UHoudiniHandleComponent.__PropertyOffset_HandleType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniHandleComponent.__PropertyOffset_HandleType) = (byte)value;
			}
		}

		// Token: 0x17004AEA RID: 19178
		// (get) Token: 0x0601340C RID: 78860 RVA: 0x001C5006 File Offset: 0x001C3206
		// (set) Token: 0x0601340D RID: 78861 RVA: 0x001C501A File Offset: 0x001C321A
		public unsafe string HandleName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniHandleComponent.__PropertyOffset_HandleName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniHandleComponent.__PropertyOffset_HandleName)), value);
			}
		}

		// Token: 0x0601340E RID: 78862 RVA: 0x001C502F File Offset: 0x001C322F
		static UHoudiniHandleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniHandleComponent");
		}

		// Token: 0x0601340F RID: 78863 RVA: 0x001C503D File Offset: 0x001C323D
		protected UHoudiniHandleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A64A RID: 42570
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniHandleComponent";

		// Token: 0x0400A64B RID: 42571
		private static IntPtr _ClassPtr;

		// Token: 0x0400A64C RID: 42572
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A64D RID: 42573
		internal static int __PropertyOffset_XformParms;

		// Token: 0x0400A64E RID: 42574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniHandleParameter> _XformParms;

		// Token: 0x0400A64F RID: 42575
		internal static int __PropertyOffset_RSTParm;

		// Token: 0x0400A650 RID: 42576
		internal static int __PropertyOffset_RotOrderParm;

		// Token: 0x0400A651 RID: 42577
		internal static int __PropertyOffset_HandleType;

		// Token: 0x0400A652 RID: 42578
		internal static int __PropertyOffset_HandleName;
	}
}
