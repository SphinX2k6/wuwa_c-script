using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B9E RID: 7070
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingPropertyDebugger")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UKuroRenderingPropertyDebugger : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AEA9 RID: 110249 RVA: 0x0027AE49 File Offset: 0x00279049
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderingPropertyDebugger._ClassPtr;
		}

		// Token: 0x0601AEAA RID: 110250 RVA: 0x0027AE58 File Offset: 0x00279058
		public UKuroRenderingPropertyDebugger() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingPropertyDebugger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AEAB RID: 110251 RVA: 0x0027AE80 File Offset: 0x00279080
		public UKuroRenderingPropertyDebugger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingPropertyDebugger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C69 RID: 27753
		// (get) Token: 0x0601AEAC RID: 110252 RVA: 0x0027AEB3 File Offset: 0x002790B3
		// (set) Token: 0x0601AEAD RID: 110253 RVA: 0x0027AEC7 File Offset: 0x002790C7
		[Nullable(2)]
		public unsafe UWorld World
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRenderingPropertyDebugger.__PropertyOffset_World);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRenderingPropertyDebugger.__PropertyOffset_World, value);
			}
		}

		// Token: 0x17006C6A RID: 27754
		// (get) Token: 0x0601AEAE RID: 110254 RVA: 0x0027AEDC File Offset: 0x002790DC
		// (set) Token: 0x0601AEAF RID: 110255 RVA: 0x0027AF15 File Offset: 0x00279115
		public TArray<UObject> ObjectRefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ObjectRefs) == null)
				{
					result = (this._ObjectRefs = new TArray<UObject>(base.NativePtr + (IntPtr)UKuroRenderingPropertyDebugger.__PropertyOffset_ObjectRefs, this));
				}
				return result;
			}
			set
			{
				this.ObjectRefs.CopyAssign(value);
			}
		}

		// Token: 0x0601AEB0 RID: 110256 RVA: 0x0027AF23 File Offset: 0x00279123
		static UKuroRenderingPropertyDebugger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingPropertyDebugger");
		}

		// Token: 0x0601AEB1 RID: 110257 RVA: 0x0027AF31 File Offset: 0x00279131
		protected UKuroRenderingPropertyDebugger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8FB RID: 59643
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingPropertyDebugger";

		// Token: 0x0400E8FC RID: 59644
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8FD RID: 59645
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E8FE RID: 59646
		internal static int __PropertyOffset_World;

		// Token: 0x0400E8FF RID: 59647
		internal static int __PropertyOffset_ObjectRefs;

		// Token: 0x0400E900 RID: 59648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectRefs;
	}
}
