using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000923 RID: 2339
	[UnrealObjectPath("/Script/Engine.ChaosPhysicsSettings")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FChaosPhysicsSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008125 RID: 33061 RVA: 0x000B9188 File Offset: 0x000B7388
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosPhysicsSettings._ScriptStructPtr != 0) ? FChaosPhysicsSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ChaosPhysicsSettings", ref FChaosPhysicsSettings._ScriptStructPtr);
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06008126 RID: 33062 RVA: 0x000B91AC File Offset: 0x000B73AC
		// (set) Token: 0x06008127 RID: 33063 RVA: 0x000B91BC File Offset: 0x000B73BC
		public unsafe EChaosThreadingMode DefaultThreadingModel
		{
			get
			{
				return (EChaosThreadingMode)(*(base.NativePtr + (IntPtr)FChaosPhysicsSettings.__PropertyOffset_DefaultThreadingModel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsSettings.__PropertyOffset_DefaultThreadingModel) = (byte)value;
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06008128 RID: 33064 RVA: 0x000B91CD File Offset: 0x000B73CD
		// (set) Token: 0x06008129 RID: 33065 RVA: 0x000B91DD File Offset: 0x000B73DD
		public unsafe EChaosSolverTickMode DedicatedThreadTickMode
		{
			get
			{
				return (EChaosSolverTickMode)(*(base.NativePtr + (IntPtr)FChaosPhysicsSettings.__PropertyOffset_DedicatedThreadTickMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsSettings.__PropertyOffset_DedicatedThreadTickMode) = (byte)value;
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600812A RID: 33066 RVA: 0x000B91EE File Offset: 0x000B73EE
		// (set) Token: 0x0600812B RID: 33067 RVA: 0x000B91FE File Offset: 0x000B73FE
		public unsafe EChaosBufferMode DedicatedThreadBufferMode
		{
			get
			{
				return (EChaosBufferMode)(*(base.NativePtr + (IntPtr)FChaosPhysicsSettings.__PropertyOffset_DedicatedThreadBufferMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsSettings.__PropertyOffset_DedicatedThreadBufferMode) = (byte)value;
			}
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x000B920F File Offset: 0x000B740F
		public FChaosPhysicsSettings()
		{
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x000B9217 File Offset: 0x000B7417
		public FChaosPhysicsSettings(EChaosThreadingMode DefaultThreadingModel, EChaosSolverTickMode DedicatedThreadTickMode, EChaosBufferMode DedicatedThreadBufferMode)
		{
			this.DefaultThreadingModel = DefaultThreadingModel;
			this.DedicatedThreadTickMode = DedicatedThreadTickMode;
			this.DedicatedThreadBufferMode = DedicatedThreadBufferMode;
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x000B9234 File Offset: 0x000B7434
		protected override IntPtr GetUStructPtr()
		{
			return FChaosPhysicsSettings.StaticStruct();
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x000B9240 File Offset: 0x000B7440
		[NullableContext(2)]
		public FChaosPhysicsSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x000B924A File Offset: 0x000B744A
		public FChaosPhysicsSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x000B9255 File Offset: 0x000B7455
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosPhysicsSettings(Pointer, false, true);
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x000B925F File Offset: 0x000B745F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosPhysicsSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003DCB RID: 15819
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ChaosPhysicsSettings";

		// Token: 0x04003DCC RID: 15820
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003DCD RID: 15821
		internal static int __PropertyOffset_DefaultThreadingModel;

		// Token: 0x04003DCE RID: 15822
		internal static int __PropertyOffset_DedicatedThreadTickMode;

		// Token: 0x04003DCF RID: 15823
		internal static int __PropertyOffset_DedicatedThreadBufferMode;
	}
}
