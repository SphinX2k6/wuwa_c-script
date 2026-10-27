using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001675 RID: 5749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroTrackRecorder")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroTrackRecorder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014DBA RID: 85434 RVA: 0x001EAB3F File Offset: 0x001E8D3F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTrackRecorder._ClassPtr;
		}

		// Token: 0x06014DBB RID: 85435 RVA: 0x001EAB4C File Offset: 0x001E8D4C
		public UKuroTrackRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroTrackRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014DBC RID: 85436 RVA: 0x001EAB74 File Offset: 0x001E8D74
		public UKuroTrackRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTrackRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170052A0 RID: 21152
		// (get) Token: 0x06014DBD RID: 85437 RVA: 0x001EABA7 File Offset: 0x001E8DA7
		// (set) Token: 0x06014DBE RID: 85438 RVA: 0x001EABBB File Offset: 0x001E8DBB
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

		// Token: 0x170052A1 RID: 21153
		// (get) Token: 0x06014DBF RID: 85439 RVA: 0x001EABD0 File Offset: 0x001E8DD0
		// (set) Token: 0x06014DC0 RID: 85440 RVA: 0x001EAC09 File Offset: 0x001E8E09
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

		// Token: 0x06014DC1 RID: 85441 RVA: 0x001EAC17 File Offset: 0x001E8E17
		[NullableContext(2)]
		public AActor GetShadow()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroTrackRecorder.__GetShadow_Internal(base.NativePtr));
		}

		// Token: 0x06014DC2 RID: 85442 RVA: 0x001EAC29 File Offset: 0x001E8E29
		public FGuid GetMainGuid()
		{
			return UKuroTrackRecorder.__GetMainGuid_Internal(base.NativePtr);
		}

		// Token: 0x06014DC3 RID: 85443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetShadow_Internal(IntPtr @this);

		// Token: 0x06014DC4 RID: 85444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetMainGuid_Internal(IntPtr @this);

		// Token: 0x06014DC5 RID: 85445 RVA: 0x001EAC36 File Offset: 0x001E8E36
		static UKuroTrackRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroTrackRecorder");
		}

		// Token: 0x06014DC6 RID: 85446 RVA: 0x001EAC44 File Offset: 0x001E8E44
		protected UKuroTrackRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B5E1 RID: 46561
		public new const string __ObjectPath = "/Script/KuroAnim.KuroTrackRecorder";

		// Token: 0x0400B5E2 RID: 46562
		private static IntPtr _ClassPtr;

		// Token: 0x0400B5E3 RID: 46563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B5E4 RID: 46564
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x0400B5E5 RID: 46565
		internal static int __PropertyOffset_CachedComponents;

		// Token: 0x0400B5E6 RID: 46566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _CachedComponents;
	}
}
