using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C4 RID: 10692
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.PropertyBinding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UPropertyBinding : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602785A RID: 161882 RVA: 0x003C4FB3 File Offset: 0x003C31B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPropertyBinding._ClassPtr;
		}

		// Token: 0x0602785B RID: 161883 RVA: 0x003C4FC0 File Offset: 0x003C31C0
		public UPropertyBinding() : this(BuiltinUtils.AllocNativeUObject(UPropertyBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602785C RID: 161884 RVA: 0x003C4FE8 File Offset: 0x003C31E8
		public UPropertyBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPropertyBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009778 RID: 38776
		// (get) Token: 0x0602785D RID: 161885 RVA: 0x003C501B File Offset: 0x003C321B
		// (set) Token: 0x0602785E RID: 161886 RVA: 0x003C502F File Offset: 0x003C322F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> SourceObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UPropertyBinding.__PropertyOffset_SourceObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UPropertyBinding.__PropertyOffset_SourceObject) = value;
			}
		}

		// Token: 0x17009779 RID: 38777
		// (get) Token: 0x0602785F RID: 161887 RVA: 0x003C5044 File Offset: 0x003C3244
		// (set) Token: 0x06027860 RID: 161888 RVA: 0x003C507D File Offset: 0x003C327D
		public FDynamicPropertyPath SourcePath
		{
			get
			{
				base.FastCheckIsValid();
				FDynamicPropertyPath result;
				if ((result = this._SourcePath) == null)
				{
					result = (this._SourcePath = new FDynamicPropertyPath(base.NativePtr + (IntPtr)UPropertyBinding.__PropertyOffset_SourcePath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDynamicPropertyPath.StaticStruct(), base.NativePtr + (IntPtr)UPropertyBinding.__PropertyOffset_SourcePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700977A RID: 38778
		// (get) Token: 0x06027861 RID: 161889 RVA: 0x003C509E File Offset: 0x003C329E
		// (set) Token: 0x06027862 RID: 161890 RVA: 0x003C50B2 File Offset: 0x003C32B2
		public unsafe FName DestinationProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPropertyBinding.__PropertyOffset_DestinationProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPropertyBinding.__PropertyOffset_DestinationProperty) = value;
			}
		}

		// Token: 0x06027863 RID: 161891 RVA: 0x003C50C7 File Offset: 0x003C32C7
		static UPropertyBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.PropertyBinding");
		}

		// Token: 0x06027864 RID: 161892 RVA: 0x003C50D5 File Offset: 0x003C32D5
		protected UPropertyBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AB5 RID: 88757
		public new const string __ObjectPath = "/Script/UMG.PropertyBinding";

		// Token: 0x04015AB6 RID: 88758
		private static IntPtr _ClassPtr;

		// Token: 0x04015AB7 RID: 88759
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AB8 RID: 88760
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x04015AB9 RID: 88761
		internal static int __PropertyOffset_SourcePath;

		// Token: 0x04015ABA RID: 88762
		[Nullable(2)]
		private FDynamicPropertyPath _SourcePath;

		// Token: 0x04015ABB RID: 88763
		internal static int __PropertyOffset_DestinationProperty;
	}
}
