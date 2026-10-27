using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE4 RID: 4068
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsConstraintTemplate")]
	[UnrealStructLayout(1184, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1184)]
	public class UPhysicsConstraintTemplate : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DC07 RID: 56327 RVA: 0x00143FE7 File Offset: 0x001421E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsConstraintTemplate._ClassPtr;
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x00143FF4 File Offset: 0x001421F4
		public UPhysicsConstraintTemplate() : this(BuiltinUtils.AllocNativeUObject(UPhysicsConstraintTemplate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DC09 RID: 56329 RVA: 0x0014401C File Offset: 0x0014221C
		public UPhysicsConstraintTemplate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsConstraintTemplate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600DC0A RID: 56330 RVA: 0x00144050 File Offset: 0x00142250
		// (set) Token: 0x0600DC0B RID: 56331 RVA: 0x00144089 File Offset: 0x00142289
		public FConstraintInstance DefaultInstance
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintInstance result;
				if ((result = this._DefaultInstance) == null)
				{
					result = (this._DefaultInstance = new FConstraintInstance(base.NativePtr + (IntPtr)UPhysicsConstraintTemplate.__PropertyOffset_DefaultInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintInstance.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsConstraintTemplate.__PropertyOffset_DefaultInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x001440AC File Offset: 0x001422AC
		// (set) Token: 0x0600DC0D RID: 56333 RVA: 0x001440E5 File Offset: 0x001422E5
		public TArray<FPhysicsConstraintProfileHandle> ProfileHandles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhysicsConstraintProfileHandle> result;
				if ((result = this._ProfileHandles) == null)
				{
					result = (this._ProfileHandles = new TArray<FPhysicsConstraintProfileHandle>(base.NativePtr + (IntPtr)UPhysicsConstraintTemplate.__PropertyOffset_ProfileHandles, this));
				}
				return result;
			}
			set
			{
				this.ProfileHandles.CopyAssign(value);
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600DC0E RID: 56334 RVA: 0x001440F4 File Offset: 0x001422F4
		// (set) Token: 0x0600DC0F RID: 56335 RVA: 0x0014412D File Offset: 0x0014232D
		public FConstraintProfileProperties DefaultProfile
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintProfileProperties result;
				if ((result = this._DefaultProfile) == null)
				{
					result = (this._DefaultProfile = new FConstraintProfileProperties(base.NativePtr + (IntPtr)UPhysicsConstraintTemplate.__PropertyOffset_DefaultProfile, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintProfileProperties.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsConstraintTemplate.__PropertyOffset_DefaultProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x0014414E File Offset: 0x0014234E
		static UPhysicsConstraintTemplate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsConstraintTemplate");
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x0014415C File Offset: 0x0014235C
		protected UPhysicsConstraintTemplate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076EB RID: 30443
		public new const string __ObjectPath = "/Script/Engine.PhysicsConstraintTemplate";

		// Token: 0x040076EC RID: 30444
		private static IntPtr _ClassPtr;

		// Token: 0x040076ED RID: 30445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076EE RID: 30446
		internal static int __PropertyOffset_DefaultInstance;

		// Token: 0x040076EF RID: 30447
		[Nullable(2)]
		private FConstraintInstance _DefaultInstance;

		// Token: 0x040076F0 RID: 30448
		internal static int __PropertyOffset_ProfileHandles;

		// Token: 0x040076F1 RID: 30449
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhysicsConstraintProfileHandle> _ProfileHandles;

		// Token: 0x040076F2 RID: 30450
		internal static int __PropertyOffset_DefaultProfile;

		// Token: 0x040076F3 RID: 30451
		[Nullable(2)]
		private FConstraintProfileProperties _DefaultProfile;
	}
}
