using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B0 RID: 2224
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlendProfile")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UBlendProfile : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600798E RID: 31118 RVA: 0x000ADE10 File Offset: 0x000AC010
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlendProfile._ClassPtr;
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x000ADE1C File Offset: 0x000AC01C
		public UBlendProfile() : this(BuiltinUtils.AllocNativeUObject(UBlendProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x000ADE44 File Offset: 0x000AC044
		public UBlendProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlendProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06007991 RID: 31121 RVA: 0x000ADE77 File Offset: 0x000AC077
		// (set) Token: 0x06007992 RID: 31122 RVA: 0x000ADE8B File Offset: 0x000AC08B
		[Nullable(2)]
		public unsafe USkeleton OwningSkeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UBlendProfile.__PropertyOffset_OwningSkeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlendProfile.__PropertyOffset_OwningSkeleton, value);
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x000ADEA0 File Offset: 0x000AC0A0
		// (set) Token: 0x06007994 RID: 31124 RVA: 0x000ADED9 File Offset: 0x000AC0D9
		public TArray<FBlendProfileBoneEntry> ProfileEntries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlendProfileBoneEntry> result;
				if ((result = this._ProfileEntries) == null)
				{
					result = (this._ProfileEntries = new TArray<FBlendProfileBoneEntry>(base.NativePtr + (IntPtr)UBlendProfile.__PropertyOffset_ProfileEntries, this));
				}
				return result;
			}
			set
			{
				this.ProfileEntries.CopyAssign(value);
			}
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x000ADEE7 File Offset: 0x000AC0E7
		static UBlendProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlendProfile");
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x000ADEF5 File Offset: 0x000AC0F5
		protected UBlendProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A68 RID: 14952
		public new const string __ObjectPath = "/Script/Engine.BlendProfile";

		// Token: 0x04003A69 RID: 14953
		private static IntPtr _ClassPtr;

		// Token: 0x04003A6A RID: 14954
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A6B RID: 14955
		internal static int __PropertyOffset_OwningSkeleton;

		// Token: 0x04003A6C RID: 14956
		internal static int __PropertyOffset_ProfileEntries;

		// Token: 0x04003A6D RID: 14957
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlendProfileBoneEntry> _ProfileEntries;
	}
}
