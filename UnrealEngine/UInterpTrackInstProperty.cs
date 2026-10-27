using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA7 RID: 3239
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackInstProperty")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UInterpTrackInstProperty : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3E9 RID: 41961 RVA: 0x000E901B File Offset: 0x000E721B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstProperty._ClassPtr;
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x000E9028 File Offset: 0x000E7228
		public UInterpTrackInstProperty() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x000E9050 File Offset: 0x000E7250
		public UInterpTrackInstProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x0600A3EC RID: 41964 RVA: 0x000E9083 File Offset: 0x000E7283
		// (set) Token: 0x0600A3ED RID: 41965 RVA: 0x000E9093 File Offset: 0x000E7293
		public unsafe Unusable InterpProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstProperty.__PropertyOffset_InterpProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstProperty.__PropertyOffset_InterpProperty) = value;
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x0600A3EE RID: 41966 RVA: 0x000E90A4 File Offset: 0x000E72A4
		// (set) Token: 0x0600A3EF RID: 41967 RVA: 0x000E90B8 File Offset: 0x000E72B8
		[Nullable(2)]
		public unsafe UObject PropertyOuterObjectInst
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstProperty.__PropertyOffset_PropertyOuterObjectInst);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstProperty.__PropertyOffset_PropertyOuterObjectInst, value);
			}
		}

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x000E90CD File Offset: 0x000E72CD
		static UInterpTrackInstProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstProperty");
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x000E90DB File Offset: 0x000E72DB
		protected UInterpTrackInstProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A18 RID: 23064
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstProperty";

		// Token: 0x04005A19 RID: 23065
		private static IntPtr _ClassPtr;

		// Token: 0x04005A1A RID: 23066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A1B RID: 23067
		internal static int __PropertyOffset_InterpProperty;

		// Token: 0x04005A1C RID: 23068
		internal static int __PropertyOffset_PropertyOuterObjectInst;
	}
}
