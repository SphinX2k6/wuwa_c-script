using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EAE RID: 3758
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshVisibilityInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMeshVisibilityInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CB5F RID: 52063 RVA: 0x0012876B File Offset: 0x0012696B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshVisibilityInfo._ScriptStructPtr != 0) ? FMeshVisibilityInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshVisibilityInfo", ref FMeshVisibilityInfo._ScriptStructPtr);
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0600CB60 RID: 52064 RVA: 0x0012878F File Offset: 0x0012698F
		// (set) Token: 0x0600CB61 RID: 52065 RVA: 0x001287A3 File Offset: 0x001269A3
		public unsafe FName MeshName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshVisibilityInfo.__PropertyOffset_MeshName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshVisibilityInfo.__PropertyOffset_MeshName) = value;
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0600CB62 RID: 52066 RVA: 0x001287B8 File Offset: 0x001269B8
		// (set) Token: 0x0600CB63 RID: 52067 RVA: 0x001287FB File Offset: 0x001269FB
		public TArray<FComponentInfo> Components
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FComponentInfo> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TArray<FComponentInfo>(base.NativePtr + (IntPtr)FMeshVisibilityInfo.__PropertyOffset_Components, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x0600CB64 RID: 52068 RVA: 0x00128809 File Offset: 0x00126A09
		public FMeshVisibilityInfo()
		{
		}

		// Token: 0x0600CB65 RID: 52069 RVA: 0x00128811 File Offset: 0x00126A11
		public FMeshVisibilityInfo(FName MeshName, TArray<FComponentInfo> Components)
		{
			this.MeshName = MeshName;
			this.Components = Components;
		}

		// Token: 0x0600CB66 RID: 52070 RVA: 0x00128827 File Offset: 0x00126A27
		protected override IntPtr GetUStructPtr()
		{
			return FMeshVisibilityInfo.StaticStruct();
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x00128833 File Offset: 0x00126A33
		[NullableContext(2)]
		public FMeshVisibilityInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x0012883D File Offset: 0x00126A3D
		public FMeshVisibilityInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x00128848 File Offset: 0x00126A48
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshVisibilityInfo(Pointer, false, true);
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x00128852 File Offset: 0x00126A52
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshVisibilityInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006D95 RID: 28053
		public const string __ObjectPath = "/Script/Engine.MeshVisibilityInfo";

		// Token: 0x04006D96 RID: 28054
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D97 RID: 28055
		internal static int __PropertyOffset_MeshName;

		// Token: 0x04006D98 RID: 28056
		internal static int __PropertyOffset_Components;

		// Token: 0x04006D99 RID: 28057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FComponentInfo> _Components;
	}
}
