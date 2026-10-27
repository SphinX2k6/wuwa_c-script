using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D25 RID: 3365
	[UnrealObjectPath("/Script/Engine.LevelBounds")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class ALevelBounds : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B48B RID: 46219 RVA: 0x001017FE File Offset: 0x000FF9FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelBounds._ClassPtr;
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x0010180C File Offset: 0x000FFA0C
		public ALevelBounds() : this(BuiltinUtils.AllocNativeUObject(ALevelBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x00101834 File Offset: 0x000FFA34
		[NullableContext(1)]
		public ALevelBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x0600B48E RID: 46222 RVA: 0x00101867 File Offset: 0x000FFA67
		// (set) Token: 0x0600B48F RID: 46223 RVA: 0x0010187B File Offset: 0x000FFA7B
		[Nullable(2)]
		public unsafe UBoxComponent BoxComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelBounds.__PropertyOffset_BoxComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelBounds.__PropertyOffset_BoxComponent, value);
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x00101890 File Offset: 0x000FFA90
		// (set) Token: 0x0600B491 RID: 46225 RVA: 0x001018A0 File Offset: 0x000FFAA0
		public unsafe bool bAutoUpdateBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALevelBounds.__PropertyOffset_bAutoUpdateBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALevelBounds.__PropertyOffset_bAutoUpdateBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x001018B1 File Offset: 0x000FFAB1
		static ALevelBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelBounds");
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x001018BF File Offset: 0x000FFABF
		protected ALevelBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005EEA RID: 24298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelBounds";

		// Token: 0x04005EEB RID: 24299
		private static IntPtr _ClassPtr;

		// Token: 0x04005EEC RID: 24300
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005EED RID: 24301
		internal static int __PropertyOffset_BoxComponent;

		// Token: 0x04005EEE RID: 24302
		internal static int __PropertyOffset_bAutoUpdateBounds;
	}
}
