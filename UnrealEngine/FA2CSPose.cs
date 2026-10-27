using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007A0 RID: 1952
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.A2CSPose")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FA2CSPose : FA2Pose, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065C9 RID: 26057 RVA: 0x00091F52 File Offset: 0x00090152
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FA2CSPose._ScriptStructPtr != 0) ? FA2CSPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.A2CSPose", ref FA2CSPose._ScriptStructPtr);
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x060065CA RID: 26058 RVA: 0x00091F78 File Offset: 0x00090178
		// (set) Token: 0x060065CB RID: 26059 RVA: 0x00091FBB File Offset: 0x000901BB
		public TArray<byte> ComponentSpaceFlags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ComponentSpaceFlags) == null)
				{
					result = (this._ComponentSpaceFlags = new TArray<byte>(base.NativePtr + (IntPtr)FA2CSPose.__PropertyOffset_ComponentSpaceFlags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentSpaceFlags.CopyAssign(value);
			}
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00091FC9 File Offset: 0x000901C9
		public FA2CSPose()
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00091FD1 File Offset: 0x000901D1
		public FA2CSPose(TArray<byte> ComponentSpaceFlags, TArray<FTransform> Bones)
		{
			this.ComponentSpaceFlags = ComponentSpaceFlags;
			base.Bones = Bones;
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00091FE7 File Offset: 0x000901E7
		protected override IntPtr GetUStructPtr()
		{
			return FA2CSPose.StaticStruct();
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x00091FF3 File Offset: 0x000901F3
		[NullableContext(2)]
		public FA2CSPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x00091FFD File Offset: 0x000901FD
		public FA2CSPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00092008 File Offset: 0x00090208
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FA2CSPose(Pointer, false, true);
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00092012 File Offset: 0x00090212
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FA2CSPose(Pointer, MemoryOwner);
		}

		// Token: 0x0400316D RID: 12653
		public new const string __ObjectPath = "/Script/Engine.A2CSPose";

		// Token: 0x0400316E RID: 12654
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400316F RID: 12655
		internal static int __PropertyOffset_ComponentSpaceFlags;

		// Token: 0x04003170 RID: 12656
		[Nullable(2)]
		private TArray<byte> _ComponentSpaceFlags;
	}
}
