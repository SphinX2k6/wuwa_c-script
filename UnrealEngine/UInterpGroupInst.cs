using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C82 RID: 3202
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpGroupInst")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UInterpGroupInst : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A28E RID: 41614 RVA: 0x000E6D56 File Offset: 0x000E4F56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpGroupInst._ClassPtr;
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x000E6D64 File Offset: 0x000E4F64
		public UInterpGroupInst() : this(BuiltinUtils.AllocNativeUObject(UInterpGroupInst.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x000E6D8C File Offset: 0x000E4F8C
		[NullableContext(1)]
		public UInterpGroupInst(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpGroupInst.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x0600A291 RID: 41617 RVA: 0x000E6DBF File Offset: 0x000E4FBF
		// (set) Token: 0x0600A292 RID: 41618 RVA: 0x000E6DD3 File Offset: 0x000E4FD3
		public unsafe UInterpGroup Group
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpGroup>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpGroupInst.__PropertyOffset_Group);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpGroupInst.__PropertyOffset_Group, value);
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600A293 RID: 41619 RVA: 0x000E6DE8 File Offset: 0x000E4FE8
		// (set) Token: 0x0600A294 RID: 41620 RVA: 0x000E6DFC File Offset: 0x000E4FFC
		public unsafe AActor GroupActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpGroupInst.__PropertyOffset_GroupActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpGroupInst.__PropertyOffset_GroupActor, value);
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600A295 RID: 41621 RVA: 0x000E6E14 File Offset: 0x000E5014
		// (set) Token: 0x0600A296 RID: 41622 RVA: 0x000E6E4D File Offset: 0x000E504D
		[Nullable(1)]
		public TArray<UInterpTrackInst> TrackInst
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UInterpTrackInst> result;
				if ((result = this._TrackInst) == null)
				{
					result = (this._TrackInst = new TArray<UInterpTrackInst>(base.NativePtr + (IntPtr)UInterpGroupInst.__PropertyOffset_TrackInst, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TrackInst.CopyAssign(value);
			}
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x000E6E5B File Offset: 0x000E505B
		static UInterpGroupInst()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpGroupInst");
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x000E6E69 File Offset: 0x000E5069
		protected UInterpGroupInst(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005936 RID: 22838
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpGroupInst";

		// Token: 0x04005937 RID: 22839
		private static IntPtr _ClassPtr;

		// Token: 0x04005938 RID: 22840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005939 RID: 22841
		internal static int __PropertyOffset_Group;

		// Token: 0x0400593A RID: 22842
		internal static int __PropertyOffset_GroupActor;

		// Token: 0x0400593B RID: 22843
		internal static int __PropertyOffset_TrackInst;

		// Token: 0x0400593C RID: 22844
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInterpTrackInst> _TrackInst;
	}
}
