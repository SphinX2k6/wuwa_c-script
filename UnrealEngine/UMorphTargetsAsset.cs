using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EBD RID: 3773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MorphTargetsAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMorphTargetsAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CC14 RID: 52244 RVA: 0x00129722 File Offset: 0x00127922
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMorphTargetsAsset._ClassPtr;
		}

		// Token: 0x0600CC15 RID: 52245 RVA: 0x00129730 File Offset: 0x00127930
		public UMorphTargetsAsset() : this(BuiltinUtils.AllocNativeUObject(UMorphTargetsAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CC16 RID: 52246 RVA: 0x00129758 File Offset: 0x00127958
		public UMorphTargetsAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMorphTargetsAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600CC17 RID: 52247 RVA: 0x0012978C File Offset: 0x0012798C
		// (set) Token: 0x0600CC18 RID: 52248 RVA: 0x001297C5 File Offset: 0x001279C5
		public TArray<UMorphTarget> SplitMorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMorphTarget> result;
				if ((result = this._SplitMorphTargets) == null)
				{
					result = (this._SplitMorphTargets = new TArray<UMorphTarget>(base.NativePtr + (IntPtr)UMorphTargetsAsset.__PropertyOffset_SplitMorphTargets, this));
				}
				return result;
			}
			set
			{
				this.SplitMorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x0600CC19 RID: 52249 RVA: 0x001297D3 File Offset: 0x001279D3
		static UMorphTargetsAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MorphTargetsAsset");
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x001297E1 File Offset: 0x001279E1
		protected UMorphTargetsAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DF6 RID: 28150
		public new const string __ObjectPath = "/Script/Engine.MorphTargetsAsset";

		// Token: 0x04006DF7 RID: 28151
		private static IntPtr _ClassPtr;

		// Token: 0x04006DF8 RID: 28152
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006DF9 RID: 28153
		internal static int __PropertyOffset_SplitMorphTargets;

		// Token: 0x04006DFA RID: 28154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMorphTarget> _SplitMorphTargets;
	}
}
