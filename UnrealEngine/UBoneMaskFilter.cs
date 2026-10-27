using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008D7 RID: 2263
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneMaskFilter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UBoneMaskFilter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007C73 RID: 31859 RVA: 0x000B2852 File Offset: 0x000B0A52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoneMaskFilter._ClassPtr;
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x000B2860 File Offset: 0x000B0A60
		public UBoneMaskFilter() : this(BuiltinUtils.AllocNativeUObject(UBoneMaskFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x000B2888 File Offset: 0x000B0A88
		public UBoneMaskFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoneMaskFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06007C76 RID: 31862 RVA: 0x000B28BC File Offset: 0x000B0ABC
		// (set) Token: 0x06007C77 RID: 31863 RVA: 0x000B28F5 File Offset: 0x000B0AF5
		public TArray<FInputBlendPose> BlendPoses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputBlendPose> result;
				if ((result = this._BlendPoses) == null)
				{
					result = (this._BlendPoses = new TArray<FInputBlendPose>(base.NativePtr + (IntPtr)UBoneMaskFilter.__PropertyOffset_BlendPoses, this));
				}
				return result;
			}
			set
			{
				this.BlendPoses.CopyAssign(value);
			}
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x000B2903 File Offset: 0x000B0B03
		static UBoneMaskFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoneMaskFilter");
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x000B2911 File Offset: 0x000B0B11
		protected UBoneMaskFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BA9 RID: 15273
		public new const string __ObjectPath = "/Script/Engine.BoneMaskFilter";

		// Token: 0x04003BAA RID: 15274
		private static IntPtr _ClassPtr;

		// Token: 0x04003BAB RID: 15275
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BAC RID: 15276
		internal static int __PropertyOffset_BlendPoses;

		// Token: 0x04003BAD RID: 15277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputBlendPose> _BlendPoses;
	}
}
