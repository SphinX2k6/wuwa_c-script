using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000303 RID: 771
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroTrackRecorder")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroTrackRecorder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060052F4 RID: 21236 RVA: 0x00073F6D File Offset: 0x0007216D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTrackRecorder._ClassPtr;
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00073F7C File Offset: 0x0007217C
		public UKuroTrackRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroTrackRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00073FA4 File Offset: 0x000721A4
		public UKuroTrackRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTrackRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060052F7 RID: 21239 RVA: 0x00073FD7 File Offset: 0x000721D7
		// (set) Token: 0x060052F8 RID: 21240 RVA: 0x00073FEB File Offset: 0x000721EB
		[Nullable(2)]
		public unsafe AActor TargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroTrackRecorder.__PropertyOffset_TargetActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroTrackRecorder.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060052F9 RID: 21241 RVA: 0x00074000 File Offset: 0x00072200
		// (set) Token: 0x060052FA RID: 21242 RVA: 0x00074039 File Offset: 0x00072239
		public TArray<UActorComponent> CachedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._CachedComponents) == null)
				{
					result = (this._CachedComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UKuroTrackRecorder.__PropertyOffset_CachedComponents, this));
				}
				return result;
			}
			set
			{
				this.CachedComponents.CopyAssign(value);
			}
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00074047 File Offset: 0x00072247
		[NullableContext(2)]
		public AActor GetShadow()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroTrackRecorder.__GetShadow_Internal(base.NativePtr));
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00074059 File Offset: 0x00072259
		public FGuid GetMainGuid()
		{
			return UKuroTrackRecorder.__GetMainGuid_Internal(base.NativePtr);
		}

		// Token: 0x060052FD RID: 21245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetShadow_Internal(IntPtr @this);

		// Token: 0x060052FE RID: 21246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetMainGuid_Internal(IntPtr @this);

		// Token: 0x060052FF RID: 21247 RVA: 0x00074066 File Offset: 0x00072266
		static UKuroTrackRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroTrackRecorder");
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00074074 File Offset: 0x00072274
		protected UKuroTrackRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021D5 RID: 8661
		public new const string __ObjectPath = "/Script/KuroAnim.KuroTrackRecorder";

		// Token: 0x040021D6 RID: 8662
		private static IntPtr _ClassPtr;

		// Token: 0x040021D7 RID: 8663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040021D8 RID: 8664
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x040021D9 RID: 8665
		internal static int __PropertyOffset_CachedComponents;

		// Token: 0x040021DA RID: 8666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _CachedComponents;
	}
}
