using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D7 RID: 6359
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroGridLevelSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroGridLevelSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601790F RID: 96527 RVA: 0x00227DD5 File Offset: 0x00225FD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGridLevelSubsystem._ClassPtr;
		}

		// Token: 0x06017910 RID: 96528 RVA: 0x00227DE4 File Offset: 0x00225FE4
		public UKuroGridLevelSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGridLevelSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017911 RID: 96529 RVA: 0x00227E0C File Offset: 0x0022600C
		public UKuroGridLevelSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGridLevelSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005EF5 RID: 24309
		// (get) Token: 0x06017912 RID: 96530 RVA: 0x00227E40 File Offset: 0x00226040
		// (set) Token: 0x06017913 RID: 96531 RVA: 0x00227E79 File Offset: 0x00226079
		public TMap<AKuroGridLevelActor, ULevelStreamingDynamic> LevelStreamings
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AKuroGridLevelActor, ULevelStreamingDynamic> result;
				if ((result = this._LevelStreamings) == null)
				{
					result = (this._LevelStreamings = new TMap<AKuroGridLevelActor, ULevelStreamingDynamic>(base.NativePtr + (IntPtr)UKuroGridLevelSubsystem.__PropertyOffset_LevelStreamings, this));
				}
				return result;
			}
			set
			{
				this.LevelStreamings.CopyAssign(value);
			}
		}

		// Token: 0x06017914 RID: 96532 RVA: 0x00227E87 File Offset: 0x00226087
		static UKuroGridLevelSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroGridLevelSubsystem");
		}

		// Token: 0x06017915 RID: 96533 RVA: 0x00227E95 File Offset: 0x00226095
		protected UKuroGridLevelSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCA9 RID: 52393
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroGridLevelSubsystem";

		// Token: 0x0400CCAA RID: 52394
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCAB RID: 52395
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCAC RID: 52396
		internal static int __PropertyOffset_LevelStreamings;

		// Token: 0x0400CCAD RID: 52397
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AKuroGridLevelActor, ULevelStreamingDynamic> _LevelStreamings;
	}
}
