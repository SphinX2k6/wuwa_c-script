using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000411 RID: 1041
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.TrackedGeometryGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTrackedGeometryGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060037D2 RID: 14290 RVA: 0x00055159 File Offset: 0x00053359
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrackedGeometryGroup._ScriptStructPtr != 0) ? FTrackedGeometryGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.TrackedGeometryGroup", ref FTrackedGeometryGroup._ScriptStructPtr);
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x0005517D File Offset: 0x0005337D
		// (set) Token: 0x060037D4 RID: 14292 RVA: 0x00055191 File Offset: 0x00053391
		public unsafe AARActor ARActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AARActor>(base.NativePtr / (IntPtr)sizeof(void*) + FTrackedGeometryGroup.__PropertyOffset_ARActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTrackedGeometryGroup.__PropertyOffset_ARActor, value);
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x000551A6 File Offset: 0x000533A6
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x000551BA File Offset: 0x000533BA
		public unsafe UARComponent ARComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FTrackedGeometryGroup.__PropertyOffset_ARComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTrackedGeometryGroup.__PropertyOffset_ARComponent, value);
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x000551CF File Offset: 0x000533CF
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x000551E3 File Offset: 0x000533E3
		public unsafe UARTrackedGeometry TrackedGeometry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARTrackedGeometry>(base.NativePtr / (IntPtr)sizeof(void*) + FTrackedGeometryGroup.__PropertyOffset_TrackedGeometry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTrackedGeometryGroup.__PropertyOffset_TrackedGeometry, value);
			}
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x000551F8 File Offset: 0x000533F8
		public FTrackedGeometryGroup()
		{
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x00055200 File Offset: 0x00053400
		[NullableContext(1)]
		public FTrackedGeometryGroup(AARActor ARActor, UARComponent ARComponent, UARTrackedGeometry TrackedGeometry)
		{
			this.ARActor = ARActor;
			this.ARComponent = ARComponent;
			this.TrackedGeometry = TrackedGeometry;
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x0005521D File Offset: 0x0005341D
		protected override IntPtr GetUStructPtr()
		{
			return FTrackedGeometryGroup.StaticStruct();
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00055229 File Offset: 0x00053429
		public FTrackedGeometryGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00055233 File Offset: 0x00053433
		public FTrackedGeometryGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x0005523E File Offset: 0x0005343E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrackedGeometryGroup(Pointer, false, true);
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x00055248 File Offset: 0x00053448
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrackedGeometryGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04001951 RID: 6481
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.TrackedGeometryGroup";

		// Token: 0x04001952 RID: 6482
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001953 RID: 6483
		internal static int __PropertyOffset_ARActor;

		// Token: 0x04001954 RID: 6484
		internal static int __PropertyOffset_ARComponent;

		// Token: 0x04001955 RID: 6485
		internal static int __PropertyOffset_TrackedGeometry;
	}
}
