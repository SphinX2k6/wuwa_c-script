using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006A5 RID: 1701
	[UnrealObjectPath("/Script/ControlRig.RigUnit_PointSimulation_DebugSettings")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_PointSimulation_DebugSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005A8D RID: 23181 RVA: 0x000820E1 File Offset: 0x000802E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_PointSimulation_DebugSettings._ScriptStructPtr != 0) ? FRigUnit_PointSimulation_DebugSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_PointSimulation_DebugSettings", ref FRigUnit_PointSimulation_DebugSettings._ScriptStructPtr);
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06005A8E RID: 23182 RVA: 0x00082105 File Offset: 0x00080305
		// (set) Token: 0x06005A8F RID: 23183 RVA: 0x00082115 File Offset: 0x00080315
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x00082126 File Offset: 0x00080326
		// (set) Token: 0x06005A91 RID: 23185 RVA: 0x00082136 File Offset: 0x00080336
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06005A92 RID: 23186 RVA: 0x00082147 File Offset: 0x00080347
		// (set) Token: 0x06005A93 RID: 23187 RVA: 0x00082157 File Offset: 0x00080357
		public unsafe float CollisionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_CollisionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_CollisionScale) = value;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06005A94 RID: 23188 RVA: 0x00082168 File Offset: 0x00080368
		// (set) Token: 0x06005A95 RID: 23189 RVA: 0x00082178 File Offset: 0x00080378
		public unsafe bool bDrawPointsAsSpheres
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_bDrawPointsAsSpheres) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_bDrawPointsAsSpheres) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x00082189 File Offset: 0x00080389
		// (set) Token: 0x06005A97 RID: 23191 RVA: 0x0008219D File Offset: 0x0008039D
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x000821B2 File Offset: 0x000803B2
		// (set) Token: 0x06005A99 RID: 23193 RVA: 0x000821C6 File Offset: 0x000803C6
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_DebugSettings.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x000821DB File Offset: 0x000803DB
		public FRigUnit_PointSimulation_DebugSettings()
		{
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x000821E3 File Offset: 0x000803E3
		public FRigUnit_PointSimulation_DebugSettings(bool bEnabled, float Scale, float CollisionScale, bool bDrawPointsAsSpheres, FLinearColor Color, FTransform WorldOffset)
		{
			this.bEnabled = bEnabled;
			this.Scale = Scale;
			this.CollisionScale = CollisionScale;
			this.bDrawPointsAsSpheres = bDrawPointsAsSpheres;
			this.Color = Color;
			this.WorldOffset = WorldOffset;
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00082218 File Offset: 0x00080418
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_PointSimulation_DebugSettings.StaticStruct();
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x00082224 File Offset: 0x00080424
		[NullableContext(2)]
		public FRigUnit_PointSimulation_DebugSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x0008222E File Offset: 0x0008042E
		public FRigUnit_PointSimulation_DebugSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x00082239 File Offset: 0x00080439
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_PointSimulation_DebugSettings(Pointer, false, true);
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x00082243 File Offset: 0x00080443
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_PointSimulation_DebugSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04002A69 RID: 10857
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_PointSimulation_DebugSettings";

		// Token: 0x04002A6A RID: 10858
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A6B RID: 10859
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002A6C RID: 10860
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002A6D RID: 10861
		internal static int __PropertyOffset_CollisionScale;

		// Token: 0x04002A6E RID: 10862
		internal static int __PropertyOffset_bDrawPointsAsSpheres;

		// Token: 0x04002A6F RID: 10863
		internal static int __PropertyOffset_Color;

		// Token: 0x04002A70 RID: 10864
		internal static int __PropertyOffset_WorldOffset;
	}
}
