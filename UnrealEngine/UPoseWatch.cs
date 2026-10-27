using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001022 RID: 4130
	[UnrealObjectPath("/Script/Engine.PoseWatch")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPoseWatch : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E1F6 RID: 57846 RVA: 0x0014C109 File Offset: 0x0014A309
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPoseWatch._ClassPtr;
		}

		// Token: 0x0600E1F7 RID: 57847 RVA: 0x0014C118 File Offset: 0x0014A318
		public UPoseWatch() : this(BuiltinUtils.AllocNativeUObject(UPoseWatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E1F8 RID: 57848 RVA: 0x0014C140 File Offset: 0x0014A340
		[NullableContext(1)]
		public UPoseWatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPoseWatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x0014C173 File Offset: 0x0014A373
		// (set) Token: 0x0600E1FA RID: 57850 RVA: 0x0014C187 File Offset: 0x0014A387
		[Nullable(2)]
		public unsafe UEdGraphNode Node
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEdGraphNode>(base.NativePtr / (IntPtr)sizeof(void*) + UPoseWatch.__PropertyOffset_Node);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPoseWatch.__PropertyOffset_Node, value);
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600E1FB RID: 57851 RVA: 0x0014C19C File Offset: 0x0014A39C
		// (set) Token: 0x0600E1FC RID: 57852 RVA: 0x0014C1B0 File Offset: 0x0014A3B0
		public unsafe FColor PoseWatchColour
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPoseWatch.__PropertyOffset_PoseWatchColour);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPoseWatch.__PropertyOffset_PoseWatchColour) = value;
			}
		}

		// Token: 0x0600E1FD RID: 57853 RVA: 0x0014C1C5 File Offset: 0x0014A3C5
		static UPoseWatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PoseWatch");
		}

		// Token: 0x0600E1FE RID: 57854 RVA: 0x0014C1D3 File Offset: 0x0014A3D3
		protected UPoseWatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007947 RID: 31047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PoseWatch";

		// Token: 0x04007948 RID: 31048
		private static IntPtr _ClassPtr;

		// Token: 0x04007949 RID: 31049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400794A RID: 31050
		internal static int __PropertyOffset_Node;

		// Token: 0x0400794B RID: 31051
		internal static int __PropertyOffset_PoseWatchColour;
	}
}
