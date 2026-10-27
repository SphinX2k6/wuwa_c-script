using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200102B RID: 4139
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrecomputedVisibilityOverrideVolume")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class APrecomputedVisibilityOverrideVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E8E7 RID: 59623 RVA: 0x00159FD4 File Offset: 0x001581D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APrecomputedVisibilityOverrideVolume._ClassPtr;
		}

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x00159FE0 File Offset: 0x001581E0
		public APrecomputedVisibilityOverrideVolume() : this(BuiltinUtils.AllocNativeUObject(APrecomputedVisibilityOverrideVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x0015A008 File Offset: 0x00158208
		public APrecomputedVisibilityOverrideVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APrecomputedVisibilityOverrideVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600E8EA RID: 59626 RVA: 0x0015A03C File Offset: 0x0015823C
		// (set) Token: 0x0600E8EB RID: 59627 RVA: 0x0015A075 File Offset: 0x00158275
		public TArray<AActor> OverrideVisibleActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._OverrideVisibleActors) == null)
				{
					result = (this._OverrideVisibleActors = new TArray<AActor>(base.NativePtr + (IntPtr)APrecomputedVisibilityOverrideVolume.__PropertyOffset_OverrideVisibleActors, this));
				}
				return result;
			}
			set
			{
				this.OverrideVisibleActors.CopyAssign(value);
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x0015A084 File Offset: 0x00158284
		// (set) Token: 0x0600E8ED RID: 59629 RVA: 0x0015A0BD File Offset: 0x001582BD
		public TArray<AActor> OverrideInvisibleActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._OverrideInvisibleActors) == null)
				{
					result = (this._OverrideInvisibleActors = new TArray<AActor>(base.NativePtr + (IntPtr)APrecomputedVisibilityOverrideVolume.__PropertyOffset_OverrideInvisibleActors, this));
				}
				return result;
			}
			set
			{
				this.OverrideInvisibleActors.CopyAssign(value);
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x0015A0CC File Offset: 0x001582CC
		// (set) Token: 0x0600E8EF RID: 59631 RVA: 0x0015A105 File Offset: 0x00158305
		public TArray<FName> OverrideInvisibleLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._OverrideInvisibleLevels) == null)
				{
					result = (this._OverrideInvisibleLevels = new TArray<FName>(base.NativePtr + (IntPtr)APrecomputedVisibilityOverrideVolume.__PropertyOffset_OverrideInvisibleLevels, this));
				}
				return result;
			}
			set
			{
				this.OverrideInvisibleLevels.CopyAssign(value);
			}
		}

		// Token: 0x0600E8F0 RID: 59632 RVA: 0x0015A113 File Offset: 0x00158313
		static APrecomputedVisibilityOverrideVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrecomputedVisibilityOverrideVolume");
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x0015A121 File Offset: 0x00158321
		protected APrecomputedVisibilityOverrideVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007E6F RID: 32367
		public new const string __ObjectPath = "/Script/Engine.PrecomputedVisibilityOverrideVolume";

		// Token: 0x04007E70 RID: 32368
		private static IntPtr _ClassPtr;

		// Token: 0x04007E71 RID: 32369
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007E72 RID: 32370
		internal static int __PropertyOffset_OverrideVisibleActors;

		// Token: 0x04007E73 RID: 32371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _OverrideVisibleActors;

		// Token: 0x04007E74 RID: 32372
		internal static int __PropertyOffset_OverrideInvisibleActors;

		// Token: 0x04007E75 RID: 32373
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _OverrideInvisibleActors;

		// Token: 0x04007E76 RID: 32374
		internal static int __PropertyOffset_OverrideInvisibleLevels;

		// Token: 0x04007E77 RID: 32375
		[Nullable(2)]
		private TArray<FName> _OverrideInvisibleLevels;
	}
}
