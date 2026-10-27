using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE3 RID: 4067
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsConstraintProfileHandle")]
	[UnrealStructLayout(280, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 280)]
	public class FPhysicsConstraintProfileHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DBFB RID: 56315 RVA: 0x00143EE2 File Offset: 0x001420E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhysicsConstraintProfileHandle._ScriptStructPtr != 0) ? FPhysicsConstraintProfileHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PhysicsConstraintProfileHandle", ref FPhysicsConstraintProfileHandle._ScriptStructPtr);
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x00143F08 File Offset: 0x00142108
		// (set) Token: 0x0600DBFD RID: 56317 RVA: 0x00143F4B File Offset: 0x0014214B
		public FConstraintProfileProperties ProfileProperties
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintProfileProperties result;
				if ((result = this._ProfileProperties) == null)
				{
					result = (this._ProfileProperties = new FConstraintProfileProperties(base.NativePtr + (IntPtr)FPhysicsConstraintProfileHandle.__PropertyOffset_ProfileProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintProfileProperties.StaticStruct(), base.NativePtr + (IntPtr)FPhysicsConstraintProfileHandle.__PropertyOffset_ProfileProperties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x00143F6C File Offset: 0x0014216C
		// (set) Token: 0x0600DBFF RID: 56319 RVA: 0x00143F80 File Offset: 0x00142180
		public unsafe FName ProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicsConstraintProfileHandle.__PropertyOffset_ProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicsConstraintProfileHandle.__PropertyOffset_ProfileName) = value;
			}
		}

		// Token: 0x0600DC00 RID: 56320 RVA: 0x00143F95 File Offset: 0x00142195
		public FPhysicsConstraintProfileHandle()
		{
		}

		// Token: 0x0600DC01 RID: 56321 RVA: 0x00143F9D File Offset: 0x0014219D
		public FPhysicsConstraintProfileHandle(FConstraintProfileProperties ProfileProperties, FName ProfileName)
		{
			this.ProfileProperties = ProfileProperties;
			this.ProfileName = ProfileName;
		}

		// Token: 0x0600DC02 RID: 56322 RVA: 0x00143FB3 File Offset: 0x001421B3
		protected override IntPtr GetUStructPtr()
		{
			return FPhysicsConstraintProfileHandle.StaticStruct();
		}

		// Token: 0x0600DC03 RID: 56323 RVA: 0x00143FBF File Offset: 0x001421BF
		[NullableContext(2)]
		public FPhysicsConstraintProfileHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x00143FC9 File Offset: 0x001421C9
		public FPhysicsConstraintProfileHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DC05 RID: 56325 RVA: 0x00143FD4 File Offset: 0x001421D4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhysicsConstraintProfileHandle(Pointer, false, true);
		}

		// Token: 0x0600DC06 RID: 56326 RVA: 0x00143FDE File Offset: 0x001421DE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhysicsConstraintProfileHandle(Pointer, MemoryOwner);
		}

		// Token: 0x040076E6 RID: 30438
		public const string __ObjectPath = "/Script/Engine.PhysicsConstraintProfileHandle";

		// Token: 0x040076E7 RID: 30439
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040076E8 RID: 30440
		internal static int __PropertyOffset_ProfileProperties;

		// Token: 0x040076E9 RID: 30441
		[Nullable(2)]
		private FConstraintProfileProperties _ProfileProperties;

		// Token: 0x040076EA RID: 30442
		internal static int __PropertyOffset_ProfileName;
	}
}
